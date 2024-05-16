using ApiResponseReplay;
using Newtonsoft.Json;

public static class Utils
{
    public static async Task<ApiResponse<T>?> ReadResponseAsync<T>(HttpResponseMessage response)
    {
        var json = await response.Content.ReadAsStringAsync();
        var apiResponse = await Task.Run(() => JsonConvert.DeserializeObject<ApiResponse<T>>(json));

        if (apiResponse is not null)
        {
            apiResponse.HttpStatusCode = response.StatusCode;
            apiResponse.Headers = response.Headers;
        }

        return apiResponse;
    }


    public static void ValidateCheckPayerAuthenticationEnrollmentApiResponse(ApiResponse<CheckPayerAuthenticationEnrollmentApiResponse> response, CheckPayerAuthenticationEnrollmentServiceRequest request)
    {
        ValidatePaymentOperationApiResponse(response, request.OrderId, request.IsLive);
        var internalData = CreateSystemRequiredInternalData(response.Result);

        if (response.Result?.Authentication?.Request != null
            && response.Result?.Order.Status == ServiceConstants.OrderStatusType.ThreeDSEnrollChecked
            && (string.IsNullOrWhiteSpace(response.Result.Authentication.Request.Html)))
        {
            var internalContext = CreateBasicInternalContext(request.OrderId, request.IsLive, response.GetBeautifyResponseLog());
            //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.PayerAuthenticationUrlIsNotAvailable, internalContext: internalContext, internalData: internalData));
            throw new Exception("PayerAuthenticationUrlIsNotAvailable");
        }

        var uiData = new Dictionary<string, object>();

        if (response.Result?.Order != null
            && !string.IsNullOrEmpty(response.Result.Order.Status)
            && response.Result.Order.Status.Equals(ServiceConstants.OrderStatusType.Failed, StringComparison.InvariantCultureIgnoreCase))
        {
            var internalContext = CreateBasicInternalContext(request.OrderId, request.IsLive, response.GetBeautifyResponseLog());

            throw new Exception("OrderIsFailed");
            //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.OrderIsFailed, internalContext: internalContext, internalData: internalData, uiData: uiData));
        }

        var validatePaymentApiParameters = new ValidatePaymentApiParameters
        {
            BaseApiResponse = response.Result,
            ResultCode = response.ResultCode,
            ResultClass = response.ResultClass,
            OrderId = request.OrderId,
            IsLive = request.IsLive,
            BeautifiedResponseLog = response.GetBeautifyResponseLog(),
            InternalData = internalData,
            UiData = uiData
        };

        ValidatePaymentApiResponseCodes(validatePaymentApiParameters);
    }


    private static void ValidatePaymentApiResponseCodes(ValidatePaymentApiParameters validatePaymentApiParameters)
    {
        if (validatePaymentApiParameters.ResultCode > 0)
        {
            var internalContext = CreateBasicInternalContext(validatePaymentApiParameters.OrderId, validatePaymentApiParameters.IsLive, validatePaymentApiParameters.BeautifiedResponseLog, validatePaymentApiParameters.BaseApiResponse?.Order?.Status);

            if (validatePaymentApiParameters.ResultCode == 19092)
            {
                if (validatePaymentApiParameters.UiData == null)
                {
                    validatePaymentApiParameters.UiData = new Dictionary<string, object>();
                }

                validatePaymentApiParameters.UiData.Add(ServiceConstants.UIData.StayCurrentPage, true);

                //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.NotSupportedCardBrand, internalContext: internalContext, internalData: validatePaymentApiParameters.InternalData, uiData: validatePaymentApiParameters.UiData));
                throw new Exception("");
            }

            if (validatePaymentApiParameters.ResultCode == 19001)
            {
                //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.InvalidOrderId, internalContext: internalContext, uiData: validatePaymentApiParameters.UiData));
                throw new Exception("InvalidOrderId");
            }

            if (validatePaymentApiParameters.ResultCode == 10088)
            {
                //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.OrderHasBeenExpired, internalContext: internalContext, internalData: validatePaymentApiParameters.InternalData, uiData: validatePaymentApiParameters.UiData));
                throw new Exception("OrderHasBeenExpired");
            }

            //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.ResultCodeIsBiggerThanZero, internalContext: internalContext, internalData: validatePaymentApiParameters.InternalData, uiData: validatePaymentApiParameters.UiData));
            throw new Exception("ResultCodeIsBiggerThanZero");
        }

        if (validatePaymentApiParameters.ResultClass > 0)
        {
            var internalContext = CreateBasicInternalContext(validatePaymentApiParameters.OrderId, validatePaymentApiParameters.IsLive, validatePaymentApiParameters.BeautifiedResponseLog, validatePaymentApiParameters.BaseApiResponse?.Order?.Status);

            //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.ResultClassIsBiggerThanZero, internalContext: internalContext, internalData: validatePaymentApiParameters.InternalData, uiData: validatePaymentApiParameters.UiData));
            throw new Exception("ResultClassIsBiggerThanZero");
        }

        if (validatePaymentApiParameters.BaseApiResponse == null)
        {
            var internalContext = CreateBasicInternalContext(validatePaymentApiParameters.OrderId, validatePaymentApiParameters.IsLive, validatePaymentApiParameters.BeautifiedResponseLog);

            //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.ApiResultObjectIsMissing, internalContext: internalContext, internalData: validatePaymentApiParameters.InternalData, uiData: validatePaymentApiParameters.UiData));
            throw new Exception("ApiResultObjectIsMissing");
        }
    }

    private static Dictionary<string, string> CreateBasicInternalContext(long orderId, bool isLive, string beautifiedResponseLog, string orderStatus = null)
    {
        return new Dictionary<string, string>
        {
            [ServiceConstants.General.OrderId] = orderId.ToString(),
            [ServiceConstants.General.IsLive] = isLive.ToString(),
            [ServiceConstants.General.ApiResponseInfo] = beautifiedResponseLog,
            [ServiceConstants.General.OrderStatus] = orderStatus
        };
    }

    private static Dictionary<string, object> CreateSystemRequiredInternalData(BaseApiResponse baseApiResponse)
    {
        var internalData = new Dictionary<string, object>();

        if (!string.IsNullOrWhiteSpace(baseApiResponse?.Order?.Reference))
        {
            internalData.Add(ServiceConstants.UIData.OrderReference, baseApiResponse.Order.Reference);
        }

        if (!string.IsNullOrWhiteSpace(baseApiResponse?.Configuration?.ReturnUrl))
        {
            internalData.Add(ServiceConstants.UIData.MerchantReturnUrl, baseApiResponse.Configuration.ReturnUrl);
        }

        if (!string.IsNullOrWhiteSpace(baseApiResponse?.Business?.Id))
        {
            internalData.Add(ServiceConstants.UIData.BusinessIdentifier, baseApiResponse.Business.Id);
        }

        return internalData;
    }

    private static void ValidatePaymentOperationApiResponse(object apiResponse, long orderId, bool isLive)
    {
        if (apiResponse == null)
        {
            var internalContext = new Dictionary<string, string>
            {
                [ServiceConstants.General.OrderId] = orderId.ToString(),
                [ServiceConstants.General.IsLive] = isLive.ToString()
            };

            throw new Exception("HttpRequestResponseIsNull");
            //throw ServiceExceptionHelper.LogAndReturnException(logger, new ServiceException(errorCode: ServiceErrorCodes.HttpRequestResponseIsNull, internalContext: internalContext));
        }
    }


    internal class ValidatePaymentApiParameters
    {
        public BaseApiResponse BaseApiResponse { get; set; }
        public int ResultCode { get; set; }
        public int ResultClass { get; set; }
        public long OrderId { get; set; }
        public bool IsLive { get; set; }
        public string BeautifiedResponseLog { get; set; }
        public Dictionary<string, object> InternalData { get; set; }
        public Dictionary<string, object> UiData { get; set; }
    }
}