namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class CityService
    {
        public static jQueryXmlHttpRequest Create(SaveRequest<CityRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/City/Create", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Update(SaveRequest<CityRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/City/Update", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/City/Delete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<CityRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/City/Retrieve", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<CityRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/City/List", request, onSuccess, options);
        }
    }
    
}

