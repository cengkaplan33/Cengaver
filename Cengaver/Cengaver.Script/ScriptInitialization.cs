using Serenity;
using System.Html;

namespace Cengaver
{
    public static class ScriptInitialization
    {
        static ScriptInitialization()
        {
            Q.Config.RootNamespaces.Add("Cengaver");
        }
    }
}