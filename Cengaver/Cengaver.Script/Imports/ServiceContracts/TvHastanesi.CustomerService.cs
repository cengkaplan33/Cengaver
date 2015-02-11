namespace Cengaver.TvHastanesi
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class CustomerService
    {
        public static jQueryXmlHttpRequest Create(SaveRequest<CustomerRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Customer/Create", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Update(SaveRequest<CustomerRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Customer/Update", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Customer/Delete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Customer/Undelete", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<CustomerRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Customer/Retrieve", request, onSuccess, options);
        }
    
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<CustomerRow>> onSuccess, ServiceCallOptions options = null)
        {
            return Q.ServiceRequest("TvHastanesi/Customer/List", request, onSuccess, options);
        }
    }
    
}

