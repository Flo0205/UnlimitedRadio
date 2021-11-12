using Synapse.Api.Plugin;

namespace UnlimitedRadio
{
    [PluginInformation(
        Author = "Flo0205",
        LoadPriority = 0,
        Name = "UnlimitedRadio",
        Description = "Deactivates the radio battery",
        SynapseMajor = 2,
        SynapseMinor = 7,
        SynapsePatch = 2,
        Version = "1.0.0"
    )]
    public class PluginClass : AbstractPlugin
    {
        public override void Load()
        {
            SynapseController.Server.Logger.Info("UnlimitedRadio Load");

            new EventHandlers();
        }
    }
}