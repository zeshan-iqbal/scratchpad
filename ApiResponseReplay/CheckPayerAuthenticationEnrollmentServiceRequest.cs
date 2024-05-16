public class CheckPayerAuthenticationEnrollmentServiceRequest : BasePaymentOperationServiceRequest
{
    public string ReturnUrl { get; set; }
    public DeviceDataModel DeviceData { get; set; }

    public class DeviceDataModel
    {
        public bool JavaScriptEnabled { get; set; }
        public bool JavaEnabled { get; set; }
        public string UserAgent { get; set; }
        public string BrowserLanguage { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string TimeZoneOffset { get; set; }
        public int ColorDepth { get; set; }
        public string ScreenType { get; set; }
        public bool IsPortrait { get; set; }
        public string AcceptHeaders { get; set; }
        public string Device { get; set; }
    }
}