using CommandLine;

namespace Mattermost_Cli
{
    public class Options
    {
        [Option('c', "channel", Required = true, HelpText = "Set Mattermost channel.")]
        public string? Channel { get; set; }
        [Option('w', "webhook", Required = true, HelpText = "Set Mattermost webhook url.")]
        public string? Webhook { get; set; }
        [Option('u', "user", Required = true, HelpText = "Set user name.")]
        public string? User { get; set; }
        [Option('m', "message", Required = true, HelpText = "Set message text.")]
        public string? Message { get; set; }
        [Option('i', "iconurl", Required = false, HelpText = "Set message icon url.")]
        public string? Iconurl { get; set; }
        [Option('v', "verbose", Required = false, Default =false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
        [Option('q', "quiet", Required = false, Default = false, HelpText = "Supress any output. May not be used in combination with -v.")]
        public bool Quiet { get; set; }
    }
}
