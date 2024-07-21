using HamsterCombatAuto.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HamsterCombatAuto.Services
{
        public class SettingsManager
        {
                private readonly string _filePath;

                public SettingsManager(string filePath)
                {
                        _filePath = filePath;
                }

                public void AddOrUpdateSetting(string name, string value)
                {
                        Dictionary<string, string> settings;

                        if (string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(value))
                                return;

                        if (File.Exists(_filePath))
                        {
                                string json = File.ReadAllText(_filePath);
                                settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
                        }
                        else
                        {
                                settings = new Dictionary<string, string>();
                        }

                        settings[name] = value;

                        string updatedJson = JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(_filePath, updatedJson);
                }

                public Dictionary<string, string> GetSettings()
                {
                        if (File.Exists(_filePath))
                        {
                                string json = File.ReadAllText(_filePath);
                                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
                        }

                        return new Dictionary<string, string>();
                }

                public void DeleteSetting(string name)
                {
                        var settings = GetSettings();

                        if (settings.ContainsKey(name))
                        {
                                settings.Remove(name);

                                string updatedJson = JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(_filePath, updatedJson);
                        }
                        else
                        {
                                Console.WriteLine($"Setting '{name}' not found.");
                        }
                }

                public string GetSettingValue(string name)
                {
                        var settings = GetSettings();

                        if (settings.TryGetValue(name, out string value))
                        {
                                return value;
                        }

                        return null;
                }

                public List<AuthData> GetAuthDataList()
                {
                        if (File.Exists(_filePath))
                        {
                                string json = File.ReadAllText(_filePath);
                                Dictionary<string, string> settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();

                                return settings
                                    .Where(kv => !string.IsNullOrEmpty(kv.Key) && !string.IsNullOrEmpty(kv.Value))
                                    .Select(kv => new AuthData { name = kv.Key, password = kv.Value })
                                    .ToList();
                        }

                        return new List<AuthData>();
                }
        }
}
