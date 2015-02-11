namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class MenuService
    {
        public static jQueryXmlHttpRequest Create(SaveRequest<MenuRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Menu/Create", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Update(SaveRequest<MenuRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Menu/Update", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Menu/Delete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Menu/Undelete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<MenuRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Menu/Retrieve", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<MenuRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Menu/List", request, onSuccess, options);
        }
    }
    
}

