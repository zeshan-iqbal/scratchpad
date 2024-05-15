using System.Reflection;
using System.Resources;

namespace ErrorCodeEnumerationWithResource;

public class Program
{
    public static void Main()
    {
        var errorCodes = new List<ErrorCodeInfo>();
        var values = Enum.GetValues(typeof(ErrorCodes));
        // iterate over each enumeration value.
        foreach (var value in values)
        {
            var errorCodeNumber = (ushort) value;
            // get ErrorCodeDetails attribute
            var errorCodeDetails = (ErrorCodeDetailsAttribute)(typeof(ErrorCodes).GetField(value.ToString())
                .GetCustomAttributes(typeof(ErrorCodeDetailsAttribute))
            .FirstOrDefault());

            // get resource value
            var resourceManager = new ResourceManager("Sampler.ErrorMsg", Assembly.GetExecutingAssembly());
            var resourceMsg = resourceManager.GetString(errorCodeDetails.ResourceKey);
            
            // (ErrorCodeKey,ErrorCode,PublicErrorCode,ActionHint,HttpStatusCode,ResourceKey,CurrentErrorMsg,SuggestedErrorMsg)
            errorCodes.Add(new(value.ToString(), errorCodeNumber.ToString(), errorCodeDetails.PublicCode.ToString(), errorCodeDetails.ActionHint.ToString(), errorCodeDetails.HttpStatusCode.ToString(), errorCodeDetails.ResourceKey, resourceMsg));
        }


        using var outputFile = new StreamWriter("errorCode.csv");
        foreach (var code in errorCodes)
        {
            outputFile.WriteLine(code);
        }


        // emit this data in csv
        // (ErrorCodeKey,ErrorCode,PublicErrorCode,ActionHint,HttpStatusCode,ResourceKey,CurrentErrorMsg,SuggestedErrorMsg)
    }

    public class ErrorCodeInfo
    {
        public string ErrorCodeKey { get; }
        public string ErrorCode { get; }
        public string PublicErrorCode { get; }
        public string ActionHint { get; }
        public string HttpStatusCode { get; }
        public string ResourceKey { get; }
        public string CurrentErrorMsg { get; }

        public ErrorCodeInfo(string errorCodeKey,
            string errorCode,
            string publicErrorCode,
            string actionHint,
            string httpStatusCode,
            string resourceKey,
            string currentErrorMsg)
        {
            ErrorCodeKey = errorCodeKey;
            ErrorCode = errorCode;
            PublicErrorCode = publicErrorCode;
            ActionHint = actionHint;
            HttpStatusCode = httpStatusCode;
            ResourceKey = resourceKey;
            CurrentErrorMsg = currentErrorMsg;
        }

        public override string ToString()
        {
            return
                $"{ErrorCodeKey},{ErrorCode},{PublicErrorCode},{ActionHint},{HttpStatusCode},{ResourceKey},{CurrentErrorMsg}";
        }
    }
}