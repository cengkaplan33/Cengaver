namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class UnitService
    {
        public static jQueryXmlHttpRequest Create(SaveRequest<UnitRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Unit/Create", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Update(SaveRequest<UnitRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Unit/Update", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Unit/Delete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Unit/Undelete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<UnitRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Unit/Retrieve", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<UnitRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Unit/List", request, onSuccess, options);
        }
    }
    
}

