using System;
using System.Data;
using Serenity.Reporting;
using Serenity.Services;
using System.Collections.Generic;

namespace Marmara.Common.Repositories
{
    public class ReportDesignRepository
    {
        public ListResponse<ReportDesignItem> List(IDbConnection connection, ReportDesignListRequest request)
        {
            return new ListResponse<ReportDesignItem>
            {
                Entities = new List<ReportDesignItem>
                {
                    new ReportDesignItem { DesignId = "Default", ReportKey = request.ReportKey }
                }
            };
        }
    }
}