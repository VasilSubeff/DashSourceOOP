using System;
using System.Windows.Forms;
using System.Xml;

namespace DashSourceConfiguration
{
    class ConfigManager
    {
        public static void UpdateConfiguration(string configPath, string application, string setting, string value)
        {   
            string xPath = String.Format("/configuration/applicationSettings/{0}.Properties.Settings/setting[@name='{1}']", application, setting);
            XmlDocument config = new XmlDocument();
            config.Load(configPath);
            XmlNode node = config.DocumentElement.SelectSingleNode(xPath).FirstChild;
            node.InnerText = String.Format("{0}", value);
            config.Save(configPath);
        }
        public static string ReadSetting(string settingsFile, string setting)
        {
            string xPath = String.Format("/configuration/applicationSettings/{0}.Properties.Settings/setting[@name='{1}']", Properties.Settings.Default.backEndAppName, setting);
            XmlDocument config = new XmlDocument();
            config.Load(settingsFile);
            XmlNode node = config.DocumentElement.SelectSingleNode(xPath).FirstChild;
            return node.InnerText;
        }

        public static string ReadConnectionString(string settingsPath)
        {
            string xPath = String.Format("/configuration/connectionStrings/add");
            XmlDocument config = new XmlDocument();
            config.Load(settingsPath);
            XmlNode node = config.DocumentElement.SelectSingleNode(xPath);
            return node.Attributes["connectionString"].InnerText;
        }

        public static void UpdateConnectionString(string configPath, string value)
        {
            string xPath = String.Format("/configuration/connectionStrings/add");
            XmlDocument config = new XmlDocument();
            config.Load(configPath);
            XmlNode node = config.DocumentElement.SelectSingleNode(xPath);
            node.Attributes["connectionString"].InnerText = value;
            config.Save(configPath);
        }
    }
}
