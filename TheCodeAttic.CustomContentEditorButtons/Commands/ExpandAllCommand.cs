using Sitecore;
using Sitecore.Shell.Framework.Commands;

namespace TheCodeAttic.CustomContentEditorButtons
{
    public class ExpandAllCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            Context.ClientPage.ClientResponse.Eval("TheCodeAttic_ExpandAll();");
        }
    }
}