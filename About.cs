using Chronicle.Plugins.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Chronicle.About;

public class About : IPlugable
{
    public string PluginName => "About Chronicle";
    public string PluginDescription => "Displays the About Box for Chronicle Software";
    public Version Version => new Version(0,0,0,2);

   
    public int Execute() {
        AboutForm a = new();
        a.ShowDialog();

        return 0;
    }


   
}
