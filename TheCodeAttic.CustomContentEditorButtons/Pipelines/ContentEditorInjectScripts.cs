using Sitecore;
using Sitecore.Configuration;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;
using System.Web.UI;

namespace TheCodeAttic.CustomContentEditorButtons
{
    public class ContentEditorInjectScripts
    {
        private const string JavascriptTag = "<script src=\"{0}\"></script>";
        private const string StylesheetLinkTag = "<link href=\"{0}\" rel=\"stylesheet\" />";

        public void Process(PipelineArgs args)
        {
            this.AddControls("<script src=\"{0}\"></script>", "CustomContentEditorJavascript");
            this.AddControls("<link href=\"{0}\" rel=\"stylesheet\" />", "CustomContentEditorStylesheets");
        }

        private void AddControls(string resourceTag, string configKey)
        {
            Assert.IsNotNullOrEmpty(configKey, "Content Editor resource config key cannot be null");
            string setting = Settings.GetSetting(configKey);
            if (string.IsNullOrEmpty(setting))
                return;
            char[] chArray = new char[1] { '|' };
            foreach (string str2 in setting.Split(chArray))
                Context.ClientPage.Page.Header.Controls.Add((Control)new LiteralControl(string.Format(resourceTag,str2)));
        }
    }
}
