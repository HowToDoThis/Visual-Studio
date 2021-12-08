namespace DiscordRPforVS
{
    public class BaseDialogWindow : Microsoft.VisualStudio.PlatformUI.DialogWindow
    {
        public BaseDialogWindow()
        {
            this.HasMaximizeButton = true;
            this.HasMinimizeButton = true;
            this.HasHelpButton = true;
        }
    }
}
