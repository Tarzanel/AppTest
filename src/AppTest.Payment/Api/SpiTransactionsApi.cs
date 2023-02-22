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
       public interface ISpiTransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PaymentResponse</returns>
        PaymentResponse SpiAuthPost (AuthRequest body = null);

        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        ApiResponse<PaymentResponse> SpiAuthPostWithHttpInfo (AuthRequest body = null);
        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>PaymentResponse</returns>
        PaymentResponse SpiPaymentPost (string body = null);

        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        ApiResponse<PaymentResponse> SpiPaymentPostWithHttpInfo (string body = null);
        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PaymentResponse</returns>
        PaymentResponse SpiRiskMgmtPost (NonfinancialRequest body = null);

        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        ApiResponse<PaymentResponse> SpiRiskMgmtPostWithHttpInfo (NonfinancialRequest body = null);
        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PaymentResponse</returns>
        PaymentResponse SpiSalePost (SaleRequest body = null);

        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        ApiResponse<PaymentResponse> SpiSalePostWithHttpInfo (SaleRequest body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        System.Threading.Tasks.Task<PaymentResponse> SpiAuthPostAsync (AuthRequest body = null);

        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiAuthPostAsyncWithHttpInfo (AuthRequest body = null);
        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        System.Threading.Tasks.Task<PaymentResponse> SpiPaymentPostAsync (string body = null);

        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiPaymentPostAsyncWithHttpInfo (string body = null);
        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        System.Threading.Tasks.Task<PaymentResponse> SpiRiskMgmtPostAsync (NonfinancialRequest body = null);

        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiRiskMgmtPostAsyncWithHttpInfo (NonfinancialRequest body = null);
        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        System.Threading.Tasks.Task<PaymentResponse> SpiSalePostAsync (SaleRequest body = null);

        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiSalePostAsyncWithHttpInfo (SaleRequest body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class SpiTransactionsApi : ISpiTransactionsApi
    {
        private AppTest.Payment.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpiTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SpiTransactionsApi(String basePath)
        {            
            this.Configuration = new AppTest.Payment.Client.Configuration 
            { 
                BasePath = basePath               
            };

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpiTransactionsApi"/> class
        /// </summary>
        /// <returns></returns>
        public SpiTransactionsApi()
        {
            this.Configuration = AppTest.Payment.Client.Configuration.Default;

            ExceptionFactory = AppTest.Payment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpiTransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SpiTransactionsApi(AppTest.Payment.Client.Configuration configuration = null)
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
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PaymentResponse</returns>
        public PaymentResponse SpiAuthPost (AuthRequest body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = SpiAuthPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        public ApiResponse< PaymentResponse > SpiAuthPostWithHttpInfo (AuthRequest body = null)
        {

            var localVarPath = "./spi/Auth";
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
                Exception exception = ExceptionFactory("SpiAuthPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        public async System.Threading.Tasks.Task<PaymentResponse> SpiAuthPostAsync (AuthRequest body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = await SpiAuthPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs an SPI authorization upon a source such as a card, securing funds for later capture. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiAuthPostAsyncWithHttpInfo (AuthRequest body = null)
        {

            var localVarPath = "./spi/Auth";
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
                Exception exception = ExceptionFactory("SpiAuthPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>PaymentResponse</returns>
        public PaymentResponse SpiPaymentPost (string body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = SpiPaymentPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        public ApiResponse< PaymentResponse > SpiPaymentPostWithHttpInfo (string body = null)
        {

            var localVarPath = "./spi/Payment";
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
                Exception exception = ExceptionFactory("SpiPaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        public async System.Threading.Tasks.Task<PaymentResponse> SpiPaymentPostAsync (string body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = await SpiPaymentPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs an SPI payment completion (Auth/Sale) by SpiToken on a current transaction 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SpiToken (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiPaymentPostAsyncWithHttpInfo (string body = null)
        {

            var localVarPath = "./spi/Payment";
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
                Exception exception = ExceptionFactory("SpiPaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PaymentResponse</returns>
        public PaymentResponse SpiRiskMgmtPost (NonfinancialRequest body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = SpiRiskMgmtPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        public ApiResponse< PaymentResponse > SpiRiskMgmtPostWithHttpInfo (NonfinancialRequest body = null)
        {

            var localVarPath = "./spi/RiskMgmt";
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
                Exception exception = ExceptionFactory("SpiRiskMgmtPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        public async System.Threading.Tasks.Task<PaymentResponse> SpiRiskMgmtPostAsync (NonfinancialRequest body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = await SpiRiskMgmtPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs an SPI Nonfinancial Risk Management request 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiRiskMgmtPostAsyncWithHttpInfo (NonfinancialRequest body = null)
        {

            var localVarPath = "./spi/RiskMgmt";
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
                Exception exception = ExceptionFactory("SpiRiskMgmtPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PaymentResponse</returns>
        public PaymentResponse SpiSalePost (SaleRequest body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = SpiSalePostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PaymentResponse</returns>
        public ApiResponse< PaymentResponse > SpiSalePostWithHttpInfo (SaleRequest body = null)
        {

            var localVarPath = "./spi/Sale";
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
                Exception exception = ExceptionFactory("SpiSalePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PaymentResponse</returns>
        public async System.Threading.Tasks.Task<PaymentResponse> SpiSalePostAsync (SaleRequest body = null)
        {
             ApiResponse<PaymentResponse> localVarResponse = await SpiSalePostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs an SPI authorization with capture upon a source such as a card. 
        /// </summary>
        /// <exception cref="AppTest.Payment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentResponse>> SpiSalePostAsyncWithHttpInfo (SaleRequest body = null)
        {

            var localVarPath = "./spi/Sale";
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
                Exception exception = ExceptionFactory("SpiSalePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentResponse)));
        }

    }
}
