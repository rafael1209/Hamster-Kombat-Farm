using HamsterCombatAuto.Model;
using HamsterCombatAuto.Services;
using HamsterCombatCheats.Model;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace HamsterCombatAuto
{
        public partial class Form1 : Form
        {
                private static readonly HttpClient client = new HttpClient();
                private UpgradeList[] upgradesForBuy;
                private double earnPerSec = 0, balance = 0, earnPerHour = 0;
                SettingsManager settingsManager = new SettingsManager("settings.json");

                public Form1()
                {
                        InitializeComponent();
                        UpdateComboBoxWithSettings(comboBox1);
                        UpdateCards();
                }

                public void updateFirst(UpgradeList upgradeList)
                {
                        label1.Text = upgradeList.name;
                        label4.Text = upgradeList.level + " lvl";
                        label3.Text = $"{FormatPrice(upgradeList.currentProfitPerHour)} (+{FormatPrice(upgradeList.profitPerHourDelta)})";
                        label7.Text = FormatPrice(upgradeList.price);
                        pictureBox1.ImageLocation = $"https://hamsterkombatgame.io/images/upgrade/{upgradeList.id}.png";
                }

                public void updateSecond(UpgradeList upgradeList)
                {
                        label8.Text = upgradeList.name;
                        label5.Text = FormatPrice(upgradeList.price);
                        pictureBox2.ImageLocation = $"https://hamsterkombatgame.io/images/upgrade/{upgradeList.id}.png";
                }

                public void updateThird(UpgradeList upgradeList)
                {
                        label10.Text = upgradeList.name;
                        label9.Text = FormatPrice(upgradeList.price);
                        pictureBox3.ImageLocation = $"https://hamsterkombatgame.io/images/upgrade/{upgradeList.id}.png";
                }

                public void updateFourth(UpgradeList upgradeList)
                {
                        label12.Text = upgradeList.name;
                        label11.Text = FormatPrice(upgradeList.price);
                        pictureBox4.ImageLocation = $"https://hamsterkombatgame.io/images/upgrade/{upgradeList.id}.png";
                }

                private string FormatPrice(int price)
                {
                        if (price >= 1000000)
                        {
                                return $"{(price / 1000000.0):0.##}M";
                        }
                        else if (price >= 1000)
                        {
                                return $"{(price / 1000.0):0.##}K";
                        }
                        else
                        {
                                return $"{price}";
                        }
                }

                public static async Task<UpgradeResponse> FetchUpgradesForBuyAsync(string authToken)
                {
                        using (var client = new HttpClient())
                        {
                                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.hamsterkombatgame.io/clicker/upgrades-for-buy");
                                request.Headers.Add("Authorization", "Bearer " + authToken);

                                long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

                                var content = new StringContent($"{{\r\n  \"count\": 1,\r\n  \"availableTaps\": 1,\r\n  \"timestamp\": {timestamp}\r\n}}", System.Text.Encoding.UTF8, "application/json");
                                request.Content = content;

                                try
                                {
                                        var response = await client.SendAsync(request);
                                        response.EnsureSuccessStatusCode();
                                        return await response.Content.ReadFromJsonAsync<UpgradeResponse>();
                                }
                                catch (HttpRequestException ex)
                                {
                                        MessageBox.Show($"An error occurred: {ex.Message}");
                                        return null;
                                }
                        }
                }

                public async Task BuyUpgradeAsync(string authToken, string upgradeId)
                {
                        using (var client = new HttpClient())
                        {
                                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.hamsterkombatgame.io/clicker/buy-upgrade");
                                request.Headers.Add("Authorization", "Bearer " + authToken);

                                long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

                                var content = new StringContent($"{{\r\n  \"upgradeId\": \"{upgradeId}\",\r\n  \"timestamp\": {timestamp}\r\n}}", System.Text.Encoding.UTF8, "application/json");
                                request.Content = content;

                                try
                                {
                                        var response = await client.SendAsync(request);

                                        if (response.IsSuccessStatusCode)
                                        {
                                                Console.WriteLine("Upgrade purchased successfully!");
                                        }
                                        else
                                        {
                                                Console.WriteLine($"Error buying upgrade. Status code: {response.StatusCode}");
                                                var errorContent = await response.Content.ReadAsStringAsync();
                                                errorLabel.Text = "[" + DateTime.Now.ToShortTimeString() + "] Error details: " + errorContent;
                                        }
                                }
                                catch (HttpRequestException ex)
                                {
                                        Console.WriteLine($"An error occurred: {ex.Message}");
                                }
                        }
                }

                private void saveAuthButton_Click(object sender, EventArgs e)
                {
                        UserManagerForm form = new UserManagerForm();
                        form.ShowDialog();
                }

                public void UpdateCombobox()
                {
                        UpdateComboBoxWithSettings(comboBox1);
                }

                private void UpdateComboBoxWithSettings(ComboBox comboBox)
                {
                        comboBox.Items.Clear();

                        var settings = settingsManager.GetSettings();
                        foreach (var setting in settings)
                        {
                                comboBox.Items.Add($"{setting.Key}");
                        }

                        if (comboBox.Items.Count > 0)
                        {
                                comboBox.SelectedIndex = 0;
                        }
                }

                public static async Task<ClickerUser> SyncDataAsync(string authToken)
                {
                        using (var client = new HttpClient())
                        {
                                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.hamsterkombatgame.io/clicker/sync");
                                request.Headers.Add("Authorization", "Bearer " + authToken);

                                try
                                {
                                        var response = await client.SendAsync(request);
                                        response.EnsureSuccessStatusCode();
                                        string responseBody = await response.Content.ReadAsStringAsync();
                                        var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                                        return apiResponse.ClickerUser;
                                }
                                catch (HttpRequestException ex)
                                {
                                        MessageBox.Show($"An error occurred: {ex.Message}");
                                        return null;
                                }
                        }
                }

                private async void buyButton_Click(object sender, EventArgs e)
                {
                        var authToken = settingsManager.GetSettingValue(comboBox1.Text);

                        var response = await FetchUpgradesForBuyAsync(authToken);
                        UpgradeList minRatioUpgrade = null;

                        if (response != null)
                        {
                                upgradesForBuy = response.upgradesForBuy;

                                minRatioUpgrade = upgradesForBuy
                                    .Where(u => u.isAvailable &&
                                        !u.isExpired &&
                                        u.cooldownSeconds <= 0 &&
                                        (!u.maxLevel.HasValue || u.level < u.maxLevel.Value))
                                    .OrderBy(u => (double)u.price / u.profitPerHourDelta)
                                    .FirstOrDefault();

                                if (minRatioUpgrade != null)
                                {
                                        await BuyUpgradeAsync(authToken, minRatioUpgrade.id);
                                        UpdateCards();
                                }
                                else
                                {
                                        MessageBox.Show("Нет доступных обновлений для покупки.");
                                }
                        }
                        else
                        {
                                MessageBox.Show("Не удалось получить обновления для покупки.");
                        }
                }

                private async void updateButton_Click_1(object sender, EventArgs e)
                {
                        UpdateComboBoxWithSettings(comboBox1);
                        UpdateCards();
                }

                public async void UpdateCards()
                {
                        var authToken = settingsManager.GetSettingValue(comboBox1.Text);
                        var response = await FetchUpgradesForBuyAsync(authToken);
                        var data = await SyncDataAsync(authToken);
                        earnPerSec = data.earnPassivePerSec;
                        balance = data.BalanceCoins;
                        earnPerHour = data.earnPassivePerHour;

                        if (response != null)
                        {
                                var upgradesForBuy = response.upgradesForBuy;

                                var topUpgrades = upgradesForBuy
                                .Where(u => u.isAvailable &&
                                        !u.isExpired &&
                                        u.cooldownSeconds <= 0 &&
                                        (!u.maxLevel.HasValue || u.level < u.maxLevel.Value))
                                .OrderBy(u => (double)u.price / u.profitPerHourDelta)
                                .Take(4)
                                .ToList();

                                if (topUpgrades.Count > 0)
                                        updateFirst(topUpgrades[0]);
                                if (topUpgrades.Count > 1)
                                        updateSecond(topUpgrades[1]);
                                if (topUpgrades.Count > 2)
                                        updateThird(topUpgrades[2]);
                                if (topUpgrades.Count > 3)
                                        updateFourth(topUpgrades[3]);
                        }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                        settingsManager.DeleteSetting(comboBox1.Text);
                        UpdateComboBoxWithSettings(comboBox1);
                        UpdateCards();
                }

                private void checkBox1_CheckedChanged(object sender, EventArgs e)
                {
                        autoUpgradeTimer.Enabled = checkBox1.Checked;
                }

                private async void autoUpgradeTimer_Tick(object sender, EventArgs e)
                {
                        var authToken = settingsManager.GetSettingValue(comboBox1.Text);
                        var response = await FetchUpgradesForBuyAsync(authToken);

                        if (response != null)
                        {
                                var upgradesForBuy = response.upgradesForBuy;

                                var minRatioUpgrade = upgradesForBuy
                                    .Where(u => u.isAvailable &&
                                        !u.isExpired &&
                                        u.cooldownSeconds <= 0 &&
                                        (!u.maxLevel.HasValue || u.level < u.maxLevel.Value))
                                    .OrderBy(u => (double)u.price / u.profitPerHourDelta)
                                    .FirstOrDefault();

                                if (minRatioUpgrade != null && (double)minRatioUpgrade.price / minRatioUpgrade.profitPerHourDelta < int.Parse(textBox2.Text))
                                {
                                        await BuyUpgradeAsync(authToken, minRatioUpgrade.id);
                                        UpdateCards();
                                }
                        }
                        else
                        {
                                errorLabel.Text+=("Не удалось получить обновления для покупки.");
                        }
                }

                private void takeMoneyTimer_Tick(object sender, EventArgs e)
                {
                        List<AuthData> authData = settingsManager.GetAuthDataList();

                        foreach (var item in authData)
                        {
                                BalanceSync(item.password);
                        }
                }

                public async void BalanceSync(string authToken)
                {
                        var request = new HttpRequestMessage(HttpMethod.Post, "https://api.hamsterkombatgame.io/clicker/sync");
                        request.Headers.Add("Authorization", $"Bearer {authToken}");

                        try
                        {
                                var response = await client.SendAsync(request);
                                response.EnsureSuccessStatusCode();
                                var responseBody = await response.Content.ReadAsStringAsync();
                                JObject jsonResponse = JObject.Parse(responseBody);
                                errorLabel.Text += jsonResponse["clickerUser"]["balanceCoins"].Value<int>().ToString();
                        }
                        catch (HttpRequestException e)
                        {
                                Console.WriteLine($"Ошибка при запросе для аккаунта: {e.Message}");
                        }
                }

                private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {
                        UpdateCards();
                }

                private void updateMoneyTimer_Tick(object sender, EventArgs e)
                {
                        double newbalance = balance + earnPerSec;
                        balance = newbalance;
                        label14.Text = $"Balance: ${(FormatPrice((int)balance))} (+{FormatPrice((int)earnPerHour)})";
                }

                public static void BubbleSort<T>(T[] array, Func<T, double> keySelector)
                {
                        int n = array.Length;
                        bool swapped;
                        do
                        {
                                swapped = false;
                                for (int i = 1; i < n; i++)
                                {
                                        if (keySelector(array[i - 1]) > keySelector(array[i]))
                                        {
                                                var temp = array[i - 1];
                                                array[i - 1] = array[i];
                                                array[i] = temp;
                                                swapped = true;
                                        }
                                }
                                n--;
                        } while (swapped);
                }
        }
}
