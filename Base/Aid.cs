using AlgernonCommons.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TMAIDBOX.Structure;
using UnityEngine;

namespace TMAIDBOX
{
    public class Aid
    {
        public void StartProcedure()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string colossalOrderFolder = "Colossal Order";
            string citiesSkylinesFolder = "Cities_Skylines";
            string ThemeMixerSettingsXMLFile = "ThemeMixerSettings.xml";


            string colossalOrderPath = Path.Combine(localAppData, colossalOrderFolder);
            string citiesSkylinesPath = Path.Combine(colossalOrderPath, citiesSkylinesFolder);
            string ThemeMixerSettingsPath = Path.Combine(citiesSkylinesPath, ThemeMixerSettingsXMLFile);

            if (File.Exists(ThemeMixerSettingsPath))
            {
                try
                {
                    File.Delete(ThemeMixerSettingsPath);
                    DeleteThemeMixerXML();
                    UnityEngine.Debug.Log("2.5AidBox: File deleted successfully");
                    CompletedNotification notification = NotificationBase.ShowNotification<CompletedNotification>();
                    notification.AddParas("Operation completed. Perform the following steps:"
                        + "\n1. Restart the game and proceed to the main menu."
                        + "\n2. Disable the Theme Mixer 2 or 2.5 mod, then re-enable it."
                        + "\n3. Load into your city."
                        + "\n4. Completely close the game."
                        + "\n5. Please be advised that in cases where ModException issues arise with TM, it is recommended to establish a pagefile. Roughly 50% of such issues stem from the absence of a pagefile, potentially causing the error."); // Added step for verifying game files

                }
                catch (Exception ex)
                {
                    UnityEngine.Debug.Log("2.5AidBox: Error deleting file: " + ex.Message);
                    CompletedNotification notification = NotificationBase.ShowNotification<CompletedNotification>();
                    notification.AddParas("Operation failed. Run as administrator, Verify game files or redownload Theme Mixer 2/2.5 ");
                }
            }
            else
            {
                UnityEngine.Debug.Log("2.5AidBox: File does not exist");
                CompletedNotification notification = NotificationBase.ShowNotification<CompletedNotification>();
                notification.AddParas("Operation information: ThemeMixerSettings.xml does not exist or cannot be found. ");
            }
        }

        public void CheckThemeIntegrity()
        {

        }

        public void DeleteThemeMixerXML()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string colossalOrderFolder = "Colossal Order";
            string citiesSkylinesFolder = "Cities_Skylines";
            string ThemeMixerSettingsXMLFile = "ThemeMixer.xml";


            string colossalOrderPath = Path.Combine(localAppData, colossalOrderFolder);
            string citiesSkylinesPath = Path.Combine(colossalOrderPath, citiesSkylinesFolder);
            string ThemeMixerSettingsPath = Path.Combine(citiesSkylinesPath, ThemeMixerSettingsXMLFile);

            if (File.Exists(ThemeMixerSettingsPath))
            {
                try
                {
                    File.Delete(ThemeMixerSettingsPath);
                    UnityEngine.Debug.Log("2.5AidBox: ThemeMixer.xml deleted successfully");
                }
                catch (Exception ex)
                {
                    UnityEngine.Debug.Log("2.5AidBox: Error deleting file: " + ex.Message);
                }
            }
            else
            {
                UnityEngine.Debug.Log("2.5AidBox: ThemeMixer.xml does not exist");
                CompletedNotification notification = NotificationBase.ShowNotification<CompletedNotification>();
                notification.AddParas("Operation information: ThemeMixer.xml does not exist or cannot be found. ");
            }
        }
    }
    }

