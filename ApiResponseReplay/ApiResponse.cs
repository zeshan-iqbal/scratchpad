using System.Net;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace ApiResponseReplay;

[Serializable]
public sealed class ApiResponse<T>
{
    /// <summary>
    /// Represents result code for HTTP response.
    /// </summary>
    public int ResultCode { get; set; }

    /// <summary>
    /// Returns true if ResultCode = 0, otherwise false.
    /// </summary>
    public bool IsSuccessCode => ResultCode == 0;

    /// <summary>
    /// Contains response message.
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Represents result class for the API response. 
    /// </summary>
    public int ResultClass { get; set; }

    /// <summary>
    /// Represents action hint against the API response.
    /// </summary>
    public string ActionHint { get; set; } = string.Empty;

    /// <summary>
    /// Contains guid value as a request reference.
    /// </summary>
    public Guid RequestReference { get; set; }

    /// <summary>
    /// Contains value for the HTTP status code.
    /// </summary>
    [JsonIgnore]
    public HttpStatusCode HttpStatusCode { get; set; }

    [NonSerialized]
    private HttpResponseHeaders headers = default!;

    /// <summary>
    /// Represents HTTP response headers.
    /// </summary>
    [JsonIgnore]
    public HttpResponseHeaders Headers
    {
        get => headers;
        set => headers = value;
    }

    /// <summary>
    /// Represents generic result object.
    /// </summary>
    public T Result { get; set; } = default!;

    /// <summary>
    /// Format response details for logging.
    /// </summary>
    /// <returns></returns>
    public string GetBeautifyResponseLog()
    {
        return $"ResultCode: {ResultCode}, ResultClass: {ResultClass}, RequestReference: {RequestReference}";
    }
}