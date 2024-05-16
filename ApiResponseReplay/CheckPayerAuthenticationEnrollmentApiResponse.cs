public class CheckPayerAuthenticationEnrollmentApiResponse : BaseApiResponse
{
    public string NextActions { get; set; }
    public AuthenticationModel Authentication { get; set; }

    public class AuthenticationModel
    {
        public AuthenticationRequestModel Request { get; set; }
        public AuthenticationRequestModel Response { get; set; }
    }

    public class AuthenticationRequestModel
    {
        public string Html { get; set; }
        public Dictionary<string, string> Nvp { get; set; }
    }
}