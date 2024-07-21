using HamsterCombatAuto.Model;
using HamsterCombatAuto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamsterCombatAuto
{
        public partial class UserManagerForm : Form
        {
                SettingsManager settingsManager = new SettingsManager("settings.json");

                public UserManagerForm()
                {
                        InitializeComponent();
                        UpdateListBox(listBox1);
                }

                private void saveAuthButton_Click(object sender, EventArgs e)
                {
                        settingsManager.AddOrUpdateSetting(textBox1.Text, authTextBox.Text);
                        UpdateListBox(listBox1);
                }

                public void UpdateListBox(ListBox listBox)
                {
                        listBox.Items.Clear();

                        List<AuthData> list = new List<AuthData>();

                        list = settingsManager.GetAuthDataList();

                        foreach (AuthData auth in list)
                        {
                                listBox.Items.Add(auth.name);
                        }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                        if (listBox1.SelectedItem == null)
                                return;

                        settingsManager.DeleteSetting(listBox1.SelectedItem.ToString());

                        UpdateListBox(listBox1 );
                }
        }
}
