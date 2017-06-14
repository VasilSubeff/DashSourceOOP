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
        public static string ReadSetting(string configPath, string application, string setting)
        {
            string xPath = String.Format("/configuration/applicationSettings/{0}.Properties.Settings/setting[@name='{1}']", application, setting);
            XmlDocument config = new XmlDocument();
            config.Load(configPath);
            XmlNode node = config.DocumentElement.SelectSingleNode(xPath).FirstChild;
            return node.InnerText;
        }
    }
}
