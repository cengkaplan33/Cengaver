

namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [Editor]
    public class CountyEditor : LookupEditorBase<CountyRow>
    {
        public CountyEditor(jQueryObject hidden)
            : base(hidden)
        {

        }

        protected override string GetLookupKey()
        {
            return "TvHastanesi.County";
        }

        public override void Destroy()
        {
            UnbindFromCityEditor();
            base.Destroy();
        }

        protected override IEnumerable<CountyRow> GetItems(Lookup<CountyRow> lookup)
        {
            return lookup.Items.Where(x => x.CityId == CityID);
        }

        private void BindToCityEditor()
        {
            if (CityEditorID.IsEmptyOrNull())
                return;

            var cityEditor = Q.FindElementWithRelativeId(this.Element, CityEditorID).TryGetWidget<LookupEditor>();
            if (cityEditor != null)
            {
                var self = this;
                cityEditor.Element.Bind("change." + this.uniqueName, delegate
                {
                    CityID = (Int32?)cityEditor.Value.ConvertToId();
                });
            }
        }

        private void UnbindFromCityEditor()
        {
            if (CityEditorID.IsEmptyOrNull())
                return;

            var cityEditor = Q.FindElementWithRelativeId(this.Element, CityEditorID).TryGetWidget<LookupEditor>();
            if (cityEditor != null)
                cityEditor.Element.Unbind("." + this.uniqueName);
        }

        private string cityEditorID;

        [Option]
        public string CityEditorID
        {
            get
            {
                return cityEditorID;
            }
            set
            {
                if (cityEditorID != value)
                {
                    UnbindFromCityEditor();
                    cityEditorID = value;
                    BindToCityEditor();
                }
            }
        }

        private Int32? cityID;

        public Int32? CityID
        {
            get
            {
                return cityID;
            }
            set
            {
                if (cityID != value)
                {
                    cityID = value;
                    Value = null;
                    UpdateItems();
                }
            }
        }

    }
}