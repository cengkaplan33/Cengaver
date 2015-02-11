namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class ServiceTicketsService
    {
        public static jQueryXmlHttpRequest Create(SaveRequest<ServiceTicketsRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/ServiceTickets/Create", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Update(SaveRequest<ServiceTicketsRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/ServiceTickets/Update", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/ServiceTickets/Delete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/ServiceTickets/Undelete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<ServiceTicketsRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/ServiceTickets/Retrieve", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<ServiceTicketsRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/ServiceTickets/List", request, onSuccess, options);
        }
    }
    
}

