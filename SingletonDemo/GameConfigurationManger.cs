
// ------ THIS IS THE DEMO FOR SINGLETON CLASS
using System;
using System.ComponentModel;
using System.Reflection.Emit;
namespace DesignPattern
{
    public class GameConfigurationManger
    {
        private Dictionary<string, string> configurationSetting;
        private static GameConfigurationManger instance;

        // private Constructor for instantiation of configuration setting
        private GameConfigurationManger()
        {
            configurationSetting = new Dictionary<string, string>();
        }

        // for creating the single instance of GameConfigurationManger class;
        public static GameConfigurationManger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameConfigurationManger();
                }
                return instance;
            }
        }
        //method for getting configuration setting
        public string getConfigurationSetting(string key)
        {
            if (configurationSetting.ContainsKey(key))
            {
                return configurationSetting[key];
            }
            return "There is no any value regarding to this key";
        }
        //method for setting and updating a new configuration setting;
        public void setConfigurationSettting(string key, string value)
        {
            if (configurationSetting.ContainsKey(key))
            {
                configurationSetting[key] = value;
            }
            else
            {
                configurationSetting.Add(key, value);
            }

        }
        public void getAllList()
        {
            if (configurationSetting == null)
            {
                Console.WriteLine("Nothig to show");
            }
            else
            {
                foreach (KeyValuePair<string, string> conf in configurationSetting)
                {
                    Console.WriteLine($"{conf.Key}:{conf.Value}");
                }
            }

        }
    }
}