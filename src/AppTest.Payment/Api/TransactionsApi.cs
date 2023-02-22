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
        internal interface ITransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>AuthResponse</returns>
        AuthResponse AuthPost (AuthRequest body = null);

        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        ApiResponse<AuthResponse> AuthPostWithHttpInfo (AuthRequest body = null);
        /// <summary>
        /// Performs a capture on a previous authorization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CaptureResponse</returns>
        CaptureResponse CapturePost (CaptureRequest body = null);

        /// <summary>
        /// Performs a capture on a previous authorization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CaptureResponse</returns>
        ApiResponse<CaptureResponse> CapturePostWithHttpInfo (CaptureRequest body = null);
        /// <summary>
        /// Placeholder for future incremental auths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>AuthResponse</returns>
        AuthResponse IncrementalAuthPost (AuthRequest body = null);

        /// <summary>
        /// Placeholder for future incremental auths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        ApiResponse<AuthResponse> IncrementalAuthPostWithHttpInfo (AuthRequest body = null);
        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>PaymentResponse</returns>
        PaymentResponse PaymentPost (string body = null);

        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        ApiResponse<PaymentResponse> PaymentPostWithHttpInfo (string body = null);
        /// <summary>
        /// Performs a refund on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>RefundResponse</returns>
        RefundResponse RefundPost (RefundRequest body = null);

        /// <summary>
        /// Performs a refund on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of RefundResponse</returns>
        ApiResponse<RefundResponse> RefundPostWithHttpInfo (RefundRequest body = null);
        /// <summary>
        /// Performs a Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>NonfinancialResponse</returns>
        NonfinancialResponse RiskMgmtPost (NonfinancialRequest body = null);

        /// <summary>
        /// Performs a Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of NonfinancialResponse</returns>
        ApiResponse<NonfinancialResponse> RiskMgmtPostWithHttpInfo (NonfinancialRequest body = null);
        /// <summary>
        /// Performs a sale upon a source such as a card
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SaleResponse</returns>
        SaleResponse SalePost (SaleRequest body = null);

        /// <summary>
        /// Performs a sale upon a source such as a card
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SaleResponse</returns>
        ApiResponse<SaleResponse> SalePostWithHttpInfo (SaleRequest body = null);
        /// <summary>
        /// Performs a void on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>VoidResponse</returns>
        VoidResponse VoidPost (VoidRequest body = null);

        /// <summary>
        /// Performs a void on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of VoidResponse</returns>
        ApiResponse<VoidResponse> VoidPostWithHttpInfo (VoidRequest body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AuthResponse</returns>
        System.Threading.Tasks.Task<AuthResponse> AuthPostAsync (AuthRequest body = null);

        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthResponse>> AuthPostAsyncWithHttpInfo (AuthRequest body = null);
        /// <summary>
        /// Performs a capture on a previous authorization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CaptureResponse</returns>
        System.Threading.Tasks.Task<CaptureResponse> CapturePostAsync (CaptureRequest body = null);

        /// <summary>
        /// Performs a capture on a previous authorization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CaptureResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaptureResponse>> CapturePostAsyncWithHttpInfo (CaptureRequest body = null);
        /// <summary>
        /// Placeholder for future incremental auths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AuthResponse</returns>
        System.Threading.Tasks.Task<AuthResponse> IncrementalAuthPostAsync (AuthRequest body = null);

        /// <summary>
        /// Placeholder for future incremental auths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthResponse>> IncrementalAuthPostAsyncWithHttpInfo (AuthRequest body = null);
        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        System.Threading.Tasks.Task<PaymentResponse> PaymentPostAsync (string body = null);

        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> PaymentPostAsyncWithHttpInfo (string body = null);
        /// <summary>
        /// Performs a refund on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of RefundResponse</returns>
        System.Threading.Tasks.Task<RefundResponse> RefundPostAsync (RefundRequest body = null);

        /// <summary>
        /// Performs a refund on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (RefundResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RefundResponse>> RefundPostAsyncWithHttpInfo (RefundRequest body = null);
        /// <summary>
        /// Performs a Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of NonfinancialResponse</returns>
        System.Threading.Tasks.Task<NonfinancialResponse> RiskMgmtPostAsync (NonfinancialRequest body = null);

        /// <summary>
        /// Performs a Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (NonfinancialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NonfinancialResponse>> RiskMgmtPostAsyncWithHttpInfo (NonfinancialRequest body = null);
        /// <summary>
        /// Performs a sale upon a source such as a card
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SaleResponse</returns>
        System.Threading.Tasks.Task<SaleResponse> SalePostAsync (SaleRequest body = null);

        /// <summary>
        /// Performs a sale upon a source such as a card
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SaleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleResponse>> SalePostAsyncWithHttpInfo (SaleRequest body = null);
        /// <summary>
        /// Performs a void on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of VoidResponse</returns>
        System.Threading.Tasks.Task<VoidResponse> VoidPostAsync (VoidRequest body = null);

        /// <summary>
        /// Performs a void on a previous transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (VoidResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoidResponse>> VoidPostAsyncWithHttpInfo (VoidRequest body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal partial class TransactionsApi : ITransactionsApi
    {
        private AppTest.Payment.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
        {         
            this.Configuration = new AppTest.Payment.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// </summary>
        /// <returns></returns>
        public TransactionsApi()
        {
            this.Configuration = AppTest.Payment.Client.Configuration.Default;

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionsApi(AppTest.Payment.Client.Configuration configuration = null)
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
        /// Performs an authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>AuthResponse</returns>
        public AuthResponse AuthPost (AuthRequest body = null)
        {
             ApiResponse<AuthResponse> localVarResponse = AuthPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        public ApiResponse< AuthResponse > AuthPostWithHttpInfo (AuthRequest body = null)
        {

            var localVarPath = "./Auth";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AuthResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthResponse)));
        }

        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AuthResponse</returns>
        public async System.Threading.Tasks.Task<AuthResponse> AuthPostAsync (AuthRequest body = null)
        {
             ApiResponse<AuthResponse> localVarResponse = await AuthPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs an authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthResponse>> AuthPostAsyncWithHttpInfo (AuthRequest body = null)
        {

            var localVarPath = "./Auth";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AuthResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthResponse)));
        }

        /// <summary>
        /// Performs a capture on a previous authorization 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CaptureResponse</returns>
        public CaptureResponse CapturePost (CaptureRequest body = null)
        {
             ApiResponse<CaptureResponse> localVarResponse = CapturePostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs a capture on a previous authorization 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CaptureResponse</returns>
        public ApiResponse< CaptureResponse > CapturePostWithHttpInfo (CaptureRequest body = null)
        {

            var localVarPath = "./Capture";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CapturePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaptureResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CaptureResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaptureResponse)));
        }

        /// <summary>
        /// Performs a capture on a previous authorization 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CaptureResponse</returns>
        public async System.Threading.Tasks.Task<CaptureResponse> CapturePostAsync (CaptureRequest body = null)
        {
             ApiResponse<CaptureResponse> localVarResponse = await CapturePostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs a capture on a previous authorization 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CaptureResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaptureResponse>> CapturePostAsyncWithHttpInfo (CaptureRequest body = null)
        {

            var localVarPath = "./Capture";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CapturePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaptureResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CaptureResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaptureResponse)));
        }

        /// <summary>
        /// Placeholder for future incremental auths. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>AuthResponse</returns>
        public AuthResponse IncrementalAuthPost (AuthRequest body = null)
        {
             ApiResponse<AuthResponse> localVarResponse = IncrementalAuthPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Placeholder for future incremental auths. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        public ApiResponse< AuthResponse > IncrementalAuthPostWithHttpInfo (AuthRequest body = null)
        {

            var localVarPath = "./IncrementalAuth";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IncrementalAuthPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AuthResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthResponse)));
        }

        /// <summary>
        /// Placeholder for future incremental auths. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AuthResponse</returns>
        public async System.Threading.Tasks.Task<AuthResponse> IncrementalAuthPostAsync (AuthRequest body = null)
        {
             ApiResponse<AuthResponse> localVarResponse = await IncrementalAuthPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Placeholder for future incremental auths. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthResponse>> IncrementalAuthPostAsyncWithHttpInfo (AuthRequest body = null)
        {

            var localVarPath = "./IncrementalAuth";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IncrementalAuthPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AuthResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthResponse)));
        }

        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>PaymentResponse</returns>
        public PaymentResponse PaymentPost (string body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = PaymentPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        public ApiResponse< PaymentResponse > PaymentPostWithHttpInfo (string body = null)
        {

            var localVarPath = "./Payment";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        public async System.Threading.Tasks.Task<PaymentResponse> PaymentPostAsync (string body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = await PaymentPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs an FPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> PaymentPostAsyncWithHttpInfo (string body = null)
        {

            var localVarPath = "./Payment";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs a refund on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>RefundResponse</returns>
        public RefundResponse RefundPost (RefundRequest body = null)
        {
             ApiResponse<RefundResponse> localVarResponse = RefundPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs a refund on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of RefundResponse</returns>
        public ApiResponse< RefundResponse > RefundPostWithHttpInfo (RefundRequest body = null)
        {

            var localVarPath = "./Refund";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RefundResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (RefundResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RefundResponse)));
        }

        /// <summary>
        /// Performs a refund on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of RefundResponse</returns>
        public async System.Threading.Tasks.Task<RefundResponse> RefundPostAsync (RefundRequest body = null)
        {
             ApiResponse<RefundResponse> localVarResponse = await RefundPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs a refund on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (RefundResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RefundResponse>> RefundPostAsyncWithHttpInfo (RefundRequest body = null)
        {

            var localVarPath = "./Refund";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RefundResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (RefundResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RefundResponse)));
        }

        /// <summary>
        /// Performs a Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>NonfinancialResponse</returns>
        public NonfinancialResponse RiskMgmtPost (NonfinancialRequest body = null)
        {
             ApiResponse<NonfinancialResponse> localVarResponse = RiskMgmtPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs a Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of NonfinancialResponse</returns>
        public ApiResponse< NonfinancialResponse > RiskMgmtPostWithHttpInfo (NonfinancialRequest body = null)
        {

            var localVarPath = "./RiskMgmt";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RiskMgmtPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NonfinancialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (NonfinancialResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NonfinancialResponse)));
        }

        /// <summary>
        /// Performs a Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of NonfinancialResponse</returns>
        public async System.Threading.Tasks.Task<NonfinancialResponse> RiskMgmtPostAsync (NonfinancialRequest body = null)
        {
             ApiResponse<NonfinancialResponse> localVarResponse = await RiskMgmtPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs a Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (NonfinancialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NonfinancialResponse>> RiskMgmtPostAsyncWithHttpInfo (NonfinancialRequest body = null)
        {

            var localVarPath = "./RiskMgmt";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RiskMgmtPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NonfinancialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (NonfinancialResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NonfinancialResponse)));
        }

        /// <summary>
        /// Performs a sale upon a source such as a card 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SaleResponse</returns>
        public SaleResponse SalePost (SaleRequest body = null)
        {
             ApiResponse<SaleResponse> localVarResponse = SalePostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs a sale upon a source such as a card 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SaleResponse</returns>
        public ApiResponse< SaleResponse > SalePostWithHttpInfo (SaleRequest body = null)
        {

            var localVarPath = "./Sale";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SalePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaleResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (SaleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaleResponse)));
        }

        /// <summary>
        /// Performs a sale upon a source such as a card 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SaleResponse</returns>
        public async System.Threading.Tasks.Task<SaleResponse> SalePostAsync (SaleRequest body = null)
        {
             ApiResponse<SaleResponse> localVarResponse = await SalePostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs a sale upon a source such as a card 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SaleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleResponse>> SalePostAsyncWithHttpInfo (SaleRequest body = null)
        {

            var localVarPath = "./Sale";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SalePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaleResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (SaleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaleResponse)));
        }

        /// <summary>
        /// Performs a void on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>VoidResponse</returns>
        public VoidResponse VoidPost (VoidRequest body = null)
        {
             ApiResponse<VoidResponse> localVarResponse = VoidPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs a void on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of VoidResponse</returns>
        public ApiResponse< VoidResponse > VoidPostWithHttpInfo (VoidRequest body = null)
        {

            var localVarPath = "./Void";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VoidPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VoidResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VoidResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoidResponse)));
        }

        /// <summary>
        /// Performs a void on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of VoidResponse</returns>
        public async System.Threading.Tasks.Task<VoidResponse> VoidPostAsync (VoidRequest body = null)
        {
             ApiResponse<VoidResponse> localVarResponse = await VoidPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs a void on a previous transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (VoidResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoidResponse>> VoidPostAsyncWithHttpInfo (VoidRequest body = null)
        {

            var localVarPath = "./Void";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VoidPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VoidResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VoidResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoidResponse)));
        }

    }
}
