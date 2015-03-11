using Serenity;
using Serenity.Abstractions;
using Serenity.Reporting;
using System.Collections;
using System.Collections.Generic;

namespace Serenity.Reporting
{
    public abstract class SiteBaseReport : IReport, IReportWithAdditionalData
    {
        public abstract IEnumerable GetData();

        public virtual IDictionary<string, IEnumerable> GetAdditionalData()
        {
            var data = new Dictionary<string, IEnumerable>();

            var globals = new List<GlobalsData>();
            globals.Add(new GlobalsData());

            data["Globals"] = globals;

            return data;
        }

        private class GlobalsData
        {
            public GlobalsData()
            {
                var currentUser = Authorization.UserDefinition;
                if (currentUser != null)
                {
                    this.Username = currentUser.Username;
                    this.UserDisplayName = currentUser.DisplayName;
                }
            }

            public string Username { get; set; }
            public string UserDisplayName { get; set; }
        }
    }
}