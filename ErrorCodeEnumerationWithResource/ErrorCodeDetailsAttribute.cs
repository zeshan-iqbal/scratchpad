using System.Net;

namespace ErrorCodeEnumerationWithResource;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class ErrorCodeDetailsAttribute : Attribute
{
    #region Attribute Properties
    public ActionHint ActionHint { get; }
    public string ResourceKey { get; }
    public ushort PublicCode { get; set; }
    public ErrorClass ErrorClass { get; set; }
    public HttpStatusCode HttpStatusCode { get; set; }
    #endregion

    #region Constructors
    /// <remarks>
    /// Created By: Muhammad Ahsan
    ///       Date: 26 April 2016
    /// </remarks>
    public ErrorCodeDetailsAttribute(string resourceKey, ushort publicCode, ActionHint actionHint = ActionHint.Correct, ErrorClass errorClass = ErrorClass.Invalid_BadRequest, HttpStatusCode httpStatusCode = HttpStatusCode.Forbidden)
    {
        #region Initialization
        PublicCode = publicCode;
        ActionHint = actionHint;
        ResourceKey = resourceKey;
        HttpStatusCode = httpStatusCode;
        ErrorClass = errorClass;
        #endregion
    }
    #endregion
}