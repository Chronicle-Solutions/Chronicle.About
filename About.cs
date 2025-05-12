using Chronicle.Plugins.Core;

namespace Chronicle.About
{

    public class About : IPlugable
    {
        public override string PluginName => "About Chronicle";
        public override string PluginDescription => "Displays the About Box for Chronicle Software";
        public override Version Version => new Version(0, 0, 0, 2);

        public override int Execute()
        {
            throw new NotImplementedException();
        }
    }
}
