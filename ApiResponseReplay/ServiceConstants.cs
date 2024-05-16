public static class ServiceConstants
{
    public static class General
    {
        public const string TermUrl = "TermUrl";
        public const string TemporaryPaymentOption = "TemporaryPaymentOption";
        public const string ApiResponseInfo = "ApiResponseInfo";
        public const string OrderId = "OrderId";
        public const string IsLive = "IsLive";
        public const string OrderStatus = "OrderStatus";
        public const string Type = "Type";
    }

    public static class ApiOperation
    {
        public const string PortalOrderConfiguration = "PORTAL_ORDER_CONFIGURATION";
        public const string AddPaymentInfo = "ADD_PAYMENT_INFO";
        public const string Cancel = "CANCEL";
        public const string Process3D = "PROCESS_ACS_RESULT";
        public const string ProcessAuthentication = "PROCESS_AUTHENTICATION";
        public const string CheckThreeDsEnrollment = "CHECK_3DS_ENROLLMENT";
        public const string CheckOfferEligibility = "CHECK_OFFER_ELIGIBILITY";
        public const string CheckEmiEligibility = "CHECK_EMI_ELIGIBILITY";
        public const string CloneOrder = "CLONE_ORDER";
    }

    public static class Mode
    {
        public const string ModeLive = "live";
        public const string ModeTest = "test";
    }

    public static class ApiNextAction
    {
        public const string ProcessAcsResult = "PROCESS_ACS_RESULT";
        public const string ProcessAuthentication = "PROCESS_AUTHENTICATION";
    }

    public static class OrderStatusType
    {
        public const string Initiated = "INITIATED";
        public const string Failed = "FAILED";
        public const string ThreeDSEnrollChecked = "3DS_ENROLL_CHECKED";
        public const string ThreeDsEnrollInitiated = "3DS_ENROLL_INITIATED";
        public const string ThreeDSResultVerified = "3DS_RESULT_VERIFIED";
        public const string Authorized = "AUTHORIZED";
        public const string Captured = "CAPTURED";
        public const string Authenticated = "AUTHENTICATED";
        public const string PaymentInfoAdded = "PAYMENT_INFO_ADDED";
        public const string Cancelled = "CANCELLED";
        public const string PartiallyCaptured = "PARTIALLY_CAPTURED";
        public const string PartiallyRefunded = "PARTIALLY_REFUNDED";
        public const string Refunded = "REFUNDED";
        public const string MarkedForReview = "MARKED_FOR_REVIEW";
        public const string PartiallyReversed = "PARTIALLY_REVERSED";
        public const string Tokenized = "TOKENIZED";
        public const string Expired = "EXPIRED";
        public const string Reversed = "REVERSED";
        public const string Rejected = "REJECTED";
        public const string Pending = "PENDING";
        public const string Locked = "LOCKED";
    }

    public static class Endpoint
    {
        public const string Order = "order";
    }

    public static class PaymentOptions
    {
        public const string Card = "Card";
        public const string GooglePay = "GooglePay";
        public const string VisaCheckout = "VisaCheckout";
        public const string ChinaUnionPay = "ChinaUnionPay";
        public const string UnionPay = "UnionPay";
        public const string PayPal = "PayPal";
        public const string ApplePay = "ApplePay";
        public const string Knet = "Knet";
        public const string SamsungPay = "SamsungPay";
        public const string NoonPay = "NoonPay";
        public const string Emi = "Emi";
        public const string Oab = "OAB";
        public const string CardRedirection = "CardRedirection";
        public const string Fawry = "FAWRY";
        public const string Benefit = "Benefit";
        public const string Arb = "ARB";
        public const string Upg = "Upg";
        public const string Tabby = "Tabby";
        public const string Zamp = "Zamp";
        public const string ValU = "ValU";
    }

    public static class PaymentDataType
    {
        public const string CardRedirection = "CardRedirection";
        public const string Tabby = "Tabby";
        public const string Zamp = "Zamp";
        public const string ValU = "ValU";
    }

    public static class UIData
    {
        public const string OrderId = "OrderId";
        public const string OrderReference = "OrderReference";
        public const string BusinessIdentifier = "BusinessIdentifier";
        public const string MerchantReturnUrl = "MerchantReturnUrl";
        public const string StayCurrentPage = "StayCurrentPage";
        public const string IsClonableOrderStatus = "IsClonableOrderStatus";
    }

    public static class Token
    {
        public const string PaymentId = "paymentId";
        public const string Reference = "reference";
        public const string TransactionId = "transactionId";
    }

    public static class QueryParam
    {
        public const string PaymentId = "PaymentID";
        public const string Reference = "referenceNumber";
        public const string TransactionId = "transactionId";
        public const string OrderId = "i";
        public const string Profile = "p";
        public const string IntegrationMode = "im";
        public const string SecureVerificationIntegrationMode = "svm";
        public const string Status = "status";
    }

    public static class Mapping
    {
        public const string CvvRequired = "cvvRequired";
        public const string True = "true";
        public const string SupportedCardBrands = "supportedCardBrands";
        public const string NameOnCardRequired = "nameOnCardRequired";
        public const string SavedCards = "savedCards";
        public const string PrePostedCard = "prePostedCard";
        public const string SaveCard = "saveCard";
        public const string CardImplementationType = "cardImplementationType";
        public const string IsSubscriptionOrder = "isSubscriptionOrder";
        public const string RequiredCardHolderName = "requiredCardHolderName";
        public const string EncryptionSettings = "encryptionSettings";
        public const string CardRedirectionPaymentOptionContextList = "cardRedirectionPaymentOptionContextList";
        public const string Context = "context";
    }
}