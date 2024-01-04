using AlgernonCommons.Patching;
using AlgernonCommons.Translation;
using AlgernonCommons;
using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMAIDBOX
{
   
        public sealed class TMAIDBOXMod : PatcherMod<OptionsPanel, PatcherBase>, IUserMod
        {
            
            public override string BaseName => "Theme Mixer AidBox";

            /// <summary>
            /// Gets the mod's unique Harmony identfier.
            /// </summary>
            public override string HarmonyID => "com.nyoko.po.patch";

        /// <summary>
        /// Gets the mod's description for display in the content manager.
        /// </summary>
        public string Description => "Troubleshooting companion for Theme Mixer";

 
        public override void LoadSettings()
            {
                // Enable detailed logging.
                Logging.DetailLogging = true;
            }

        public override void SaveSettings()
        {
            
        }
    }
    }


