
namespace Cengaver.TvHastanesi.Reports
{
    using Entities;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using System.Collections;
    using System.ComponentModel;

    [Category("Ana Kategori/Alt Kategori"), DisplayName("Müşteri Listesi")]
    [RegisterReport, RequiredPermission("Administration")]
    public class CustomerReport : IDataOnlyReport
    {
        public IEnumerable GetData()
        {
            var fld = CustomerRow.Fields;
            var row = new CustomerRow();


            var query = new SqlQuery().From(row).SelectTableFields();
            if (!OrnekIcerir.IsEmptyOrNull())
                query.Where(fld.Name.Contains(OrnekIcerir));
            using (var connection = SqlConnections.NewByKey("Default"))
            {
                return connection.Query<Item>(query);
            }
        }

        [DisplayName("Adı Ne İçersin")]
        public string OrnekIcerir { get; set; }


        [BasedOnRow(typeof(CustomerRow))]
        public class Item
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }

        public System.Collections.Generic.List<ReportColumn> GetColumnList()
        {
            return ReportColumnConverter.ObjectTypeToList(typeof(Item));
        }
    }
}