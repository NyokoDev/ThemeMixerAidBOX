using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using AlgernonCommons.UI;
using ColossalFramework.UI;
using UnityEngine;
using System.Diagnostics;
using TMAIDBOX.Structure;
using System.Diagnostics.Eventing.Reader;
using System.Management;

namespace TMAIDBOX
{
    /// <summary>
    /// The mod's settings options panel.
    /// </summary>
    public sealed class OptionsPanel : OptionsPanelBase
    {
        // Layout constants.
        private const float Margin = 5f;
        private const float LeftMargin = 24f;
        private const float GroupMargin = 40f;
        private const float LabelWidth = 40f;
        private const float TabHeight = 20f;
        public static readonly string[] SKY_MANIPULATING_MODS = { "thememixer" };

        Aid Aid = new Aid();
        /// <summary>
        /// Performs on-demand panel setup.
        /// </summary>
        protected override void Setup()
        {
            autoLayout = false;
            float currentY = Margin;
            m_BackgroundSprite = "UnlockingPanel";

            UISprite image2Sprite = this.AddUIComponent<UISprite>();

            image2Sprite.height = 1000f;
            image2Sprite.relativePosition = new Vector3(0f, -50f);
            image2Sprite.width = 1000f;
            image2Sprite.atlas = UITextures.LoadSingleSpriteAtlas("..\\Resources\\bck");
            image2Sprite.spriteName = "normal";
            image2Sprite.zOrder = 1;


             bool POFound = ModUtils.IsModEnabled("thememixer");


        UILabel enable = UILabels.AddLabel(this, LabelWidth, currentY, "Looking for Theme Mixer", textScale: 0.7f, alignment: UIHorizontalAlignment.Center);
            currentY += 35f;
            if (POFound)
            {
                enable.text = "Theme Mixer 2.5 has been found.";

            }
            else
                enable.text = "Theme Mixer could not be located, although it is plausible that it was not detected..";

            UILabel procedureinfo = UILabels.AddLabel(this, LabelWidth, currentY, "Before you start, back up your Theme Mixer settings—they'll be deleted.", textScale: 1f, alignment: UIHorizontalAlignment.Center);
            currentY += 35f;



            UIButton startProcedureButton = UIButtons.AddSmallerButton(this, LabelWidth, currentY, "Start Procedure");
            currentY += 50f;
            startProcedureButton.eventClicked += (sender, args) =>
            {
                // Placeholder method for starting a procedure
                Aid.StartProcedure();
            };

            UIButton supportbutton = UIButtons.AddSmallerButton(this, LabelWidth, currentY, "Support");
            currentY += 50f;
            supportbutton.eventClicked += (sender, args) =>
            {
                Process.Start("https://discord.gg/gdhyhfcj7A");
            };





            UILabel version = UILabels.AddLabel(this, LabelWidth, currentY, Assembly.GetExecutingAssembly().GetName().Version.ToString(), textScale: 0.7f, alignment: UIHorizontalAlignment.Center);



        }
    }
}