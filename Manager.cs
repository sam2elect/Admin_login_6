using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_login_6
{
    public class Settings
    {
        public string DefaultPageText1 { get; set; }
        public string DefaultPageText2 { get; set; }
        public string DefaultPageText3 { get; set; }
        public string DefaultPageText4 { get; set; }
    }
    public class Manager
    {
        public Manager()
        {
            //Constructior code
        }
        public static Settings LoadSettings(string FilePath)
        {
            Settings settings = new Settings();
            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                System.IO.StreamReader file = new System.IO.StreamReader(
                   FilePath);
                settings = (Settings)reader.Deserialize(file);
                file.Close();
                return settings;
            }
            catch (Exception)
            {
                return settings;
            }
        }
        public static void SaveSettings(string FilePath, Settings settingsObj)
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Settings));

            var Filename = "Settings.xml";
            System.IO.FileStream file = System.IO.File.Create(FilePath);
            writer.Serialize(file, settingsObj);
            file.Close();
        }

    }
}
