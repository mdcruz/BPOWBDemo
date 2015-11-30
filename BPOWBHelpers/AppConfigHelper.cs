using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPOWBHelpers
{
    public static class AppConfigHelper
    {
        /// <summary>
        /// Get applicationConfiguration value from app.<ENV>.config file
        /// This automatically loads the config file for the startup application i.e. Specs
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Get(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup applicationSettingsGroup = config.GetSectionGroup("applicationSettings");
            ConfigurationSection applicationConfigSection = applicationSettingsGroup.Sections["BPOWBAutomation.Properties.Settings"];
            ClientSettingsSection clientSection = (ClientSettingsSection)applicationConfigSection;

            return clientSection.Settings.Get(key).Value.ValueXml.InnerText;
        }
    }
}
