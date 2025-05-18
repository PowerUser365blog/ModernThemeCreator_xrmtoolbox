using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernThemeCreator.Helpers
{
    public class GetClassicTheme
    {
        public EntityCollection RetrieveThemes(IOrganizationService service, string entityLogicalName, BackgroundWorker worker = null)
        {

            if (worker != null && worker.WorkerReportsProgress)
            {
                worker.ReportProgress(0, "Retrieve themes " + entityLogicalName);
            }

            var themeCollection = service.RetrieveMultiple(new QueryExpression("theme")
            {
                ColumnSet = new ColumnSet("themeid", "name", "logoid", "isdefaulttheme"),
            });

            return themeCollection;
        }
    }
}
