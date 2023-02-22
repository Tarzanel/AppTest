using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using AppTest.Payment.Client;
using AppTest.Payment.Model;
using Microsoft.Extensions.Configuration;

namespace AppTest.Payment.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal interface ITransactionQueriesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets an order by any transactionidentifiier in the order
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>OrderTrans</returns>
        OrderTrans TransactionsOrderSearchTransactionIdentifierGet (string transactionIdentifier);

        /// <summary>
        /// Gets an order by any transactionidentifiier in the order
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>ApiResponse of OrderTrans</returns>
        ApiResponse<OrderTrans> TransactionsOrderSearchTransactionIdentifierGetWithHttpInfo (string transactionIdentifier);
        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>List&lt;TransOrder&gt;</returns>
        List<TransOrder> TransactionsSearchGet (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null);

        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>ApiResponse of List&lt;TransOrder&gt;</returns>
        ApiResponse<List<TransOrder>> TransactionsSearchGetWithHttpInfo (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null);
        /// <summary>
        /// Gets a transaction by its identifier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>TransOrder</returns>
        TransOrder TransactionsTransactionIdentifierGet (string transactionIdentifier);

        /// <summary>
        /// Gets a transaction by its identifier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>ApiResponse of TransOrder</returns>
        ApiResponse<TransOrder> TransactionsTransactionIdentifierGetWithHttpInfo (string transactionIdentifier);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets an order by any transactionidentifiier in the order
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of OrderTrans</returns>
        System.Threading.Tasks.Task<OrderTrans> TransactionsOrderSearchTransactionIdentifierGetAsync (string transactionIdentifier);

        /// <summary>
        /// Gets an order by any transactionidentifiier in the order
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of ApiResponse (OrderTrans)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderTrans>> TransactionsOrderSearchTransactionIdentifierGetAsyncWithHttpInfo (string transactionIdentifier);
        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>Task of List&lt;TransOrder&gt;</returns>
        System.Threading.Tasks.Task<List<TransOrder>> TransactionsSearchGetAsync (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null);

        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TransOrder&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransOrder>>> TransactionsSearchGetAsyncWithHttpInfo (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null);
        /// <summary>
        /// Gets a transaction by its identifier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of TransOrder</returns>
        System.Threading.Tasks.Task<TransOrder> TransactionsTransactionIdentifierGetAsync (string transactionIdentifier);

        /// <summary>
        /// Gets a transaction by its identifier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of ApiResponse (TransOrder)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransOrder>> TransactionsTransactionIdentifierGetAsyncWithHttpInfo (string transactionIdentifier);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal partial class TransactionQueriesApi : ITransactionQueriesApi
    {
        private AppTest.Payment.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionQueriesApi(String basePath)
        {            
            this.Configuration = new AppTest.Payment.Client.Configuration { BasePath = basePath
            };

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueriesApi"/> class
        /// </summary>
        /// <returns></returns>
        public TransactionQueriesApi()
        {
            this.Configuration = AppTest.Payment.Client.Configuration.Default;

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueriesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionQueriesApi(AppTest.Payment.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AppTest.Payment.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AppTest.Payment.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AppTest.Payment.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Gets an order by any transactionidentifiier in the order 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>OrderTrans</returns>
        public OrderTrans TransactionsOrderSearchTransactionIdentifierGet (string transactionIdentifier)
        {
             ApiResponse<OrderTrans> localVarResponse = TransactionsOrderSearchTransactionIdentifierGetWithHttpInfo(transactionIdentifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets an order by any transactionidentifiier in the order 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>ApiResponse of OrderTrans</returns>
        public ApiResponse< OrderTrans > TransactionsOrderSearchTransactionIdentifierGetWithHttpInfo (string transactionIdentifier)
        {
            // verify the required parameter 'transactionIdentifier' is set
            if (transactionIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'transactionIdentifier' when calling TransactionQueriesApi->TransactionsOrderSearchTransactionIdentifierGet");

            var localVarPath = "./Transactions/OrderSearch/{transactionIdentifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (transactionIdentifier != null) localVarPathParams.Add("TransactionIdentifier", this.Configuration.ApiClient.ParameterToString(transactionIdentifier)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TransactionsOrderSearchTransactionIdentifierGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OrderTrans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (OrderTrans) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderTrans)));
        }

        /// <summary>
        /// Gets an order by any transactionidentifiier in the order 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of OrderTrans</returns>
        public async System.Threading.Tasks.Task<OrderTrans> TransactionsOrderSearchTransactionIdentifierGetAsync (string transactionIdentifier)
        {
             ApiResponse<OrderTrans> localVarResponse = await TransactionsOrderSearchTransactionIdentifierGetAsyncWithHttpInfo(transactionIdentifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets an order by any transactionidentifiier in the order 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of ApiResponse (OrderTrans)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderTrans>> TransactionsOrderSearchTransactionIdentifierGetAsyncWithHttpInfo (string transactionIdentifier)
        {
            // verify the required parameter 'transactionIdentifier' is set
            if (transactionIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'transactionIdentifier' when calling TransactionQueriesApi->TransactionsOrderSearchTransactionIdentifierGet");

            var localVarPath = "./Transactions/OrderSearch/{transactionIdentifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (transactionIdentifier != null) localVarPathParams.Add("TransactionIdentifier", this.Configuration.ApiClient.ParameterToString(transactionIdentifier)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TransactionsOrderSearchTransactionIdentifierGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OrderTrans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (OrderTrans) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderTrans)));
        }

        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>List&lt;TransOrder&gt;</returns>
        public List<TransOrder> TransactionsSearchGet (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null)
        {
             ApiResponse<List<TransOrder>> localVarResponse = TransactionsSearchGetWithHttpInfo(startDateTime, endDateTime, externalBatchIdentifier, terminalId, orderIdentifier, externalGroupIdentifier, authorizationCode, approved);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>ApiResponse of List&lt;TransOrder&gt;</returns>
        public ApiResponse< List<TransOrder> > TransactionsSearchGetWithHttpInfo (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null)
        {

            var localVarPath = "./Transactions/Search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDateTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "StartDateTime", startDateTime)); // query parameter
            if (endDateTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "EndDateTime", endDateTime)); // query parameter
            if (externalBatchIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ExternalBatchIdentifier", externalBatchIdentifier)); // query parameter
            if (terminalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "TerminalId", terminalId)); // query parameter
            if (orderIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "OrderIdentifier", orderIdentifier)); // query parameter
            if (externalGroupIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ExternalGroupIdentifier", externalGroupIdentifier)); // query parameter
            if (authorizationCode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "AuthorizationCode", authorizationCode)); // query parameter
            if (approved != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "Approved", approved)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TransactionsSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransOrder>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<TransOrder>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TransOrder>)));
        }

        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>Task of List&lt;TransOrder&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransOrder>> TransactionsSearchGetAsync (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null)
        {
             ApiResponse<List<TransOrder>> localVarResponse = await TransactionsSearchGetAsyncWithHttpInfo(startDateTime, endDateTime, externalBatchIdentifier, terminalId, orderIdentifier, externalGroupIdentifier, authorizationCode, approved);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a collection of transactions that meet the specified criteria. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Start date and time for transaction creation (optional)</param>
        /// <param name="endDateTime">End date and time for transaction creation (optional)</param>
        /// <param name="externalBatchIdentifier">External Batch Identifier (optional)</param>
        /// <param name="terminalId">TerminalId (optional)</param>
        /// <param name="orderIdentifier">Original OrderIdentifier (optional)</param>
        /// <param name="externalGroupIdentifier">Group Identifier (optional)</param>
        /// <param name="authorizationCode">Authorization code (optional)</param>
        /// <param name="approved">Approved status (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TransOrder&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransOrder>>> TransactionsSearchGetAsyncWithHttpInfo (DateTime? startDateTime = null, DateTime? endDateTime = null, string externalBatchIdentifier = null, string terminalId = null, string orderIdentifier = null, string externalGroupIdentifier = null, string authorizationCode = null, bool? approved = null)
        {

            var localVarPath = "./Transactions/Search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDateTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "StartDateTime", startDateTime)); // query parameter
            if (endDateTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "EndDateTime", endDateTime)); // query parameter
            if (externalBatchIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ExternalBatchIdentifier", externalBatchIdentifier)); // query parameter
            if (terminalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "TerminalId", terminalId)); // query parameter
            if (orderIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "OrderIdentifier", orderIdentifier)); // query parameter
            if (externalGroupIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ExternalGroupIdentifier", externalGroupIdentifier)); // query parameter
            if (authorizationCode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "AuthorizationCode", authorizationCode)); // query parameter
            if (approved != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "Approved", approved)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TransactionsSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransOrder>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<TransOrder>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TransOrder>)));
        }

        /// <summary>
        /// Gets a transaction by its identifier. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>TransOrder</returns>
        public TransOrder TransactionsTransactionIdentifierGet (string transactionIdentifier)
        {
             ApiResponse<TransOrder> localVarResponse = TransactionsTransactionIdentifierGetWithHttpInfo(transactionIdentifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a transaction by its identifier. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>ApiResponse of TransOrder</returns>
        public ApiResponse< TransOrder > TransactionsTransactionIdentifierGetWithHttpInfo (string transactionIdentifier)
        {
            // verify the required parameter 'transactionIdentifier' is set
            if (transactionIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'transactionIdentifier' when calling TransactionQueriesApi->TransactionsTransactionIdentifierGet");

            var localVarPath = "./Transactions/{transactionIdentifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (transactionIdentifier != null) localVarPathParams.Add("TransactionIdentifier", this.Configuration.ApiClient.ParameterToString(transactionIdentifier)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TransactionsTransactionIdentifierGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TransOrder) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransOrder)));
        }

        /// <summary>
        /// Gets a transaction by its identifier. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of TransOrder</returns>
        public async System.Threading.Tasks.Task<TransOrder> TransactionsTransactionIdentifierGetAsync (string transactionIdentifier)
        {
             ApiResponse<TransOrder> localVarResponse = await TransactionsTransactionIdentifierGetAsyncWithHttpInfo(transactionIdentifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a transaction by its identifier. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionIdentifier">Transaction identifier</param>
        /// <returns>Task of ApiResponse (TransOrder)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransOrder>> TransactionsTransactionIdentifierGetAsyncWithHttpInfo (string transactionIdentifier)
        {
            // verify the required parameter 'transactionIdentifier' is set
            if (transactionIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'transactionIdentifier' when calling TransactionQueriesApi->TransactionsTransactionIdentifierGet");

            var localVarPath = "./Transactions/{transactionIdentifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (transactionIdentifier != null) localVarPathParams.Add("TransactionIdentifier", this.Configuration.ApiClient.ParameterToString(transactionIdentifier)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TransactionsTransactionIdentifierGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TransOrder) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransOrder)));
        }

    }
}
