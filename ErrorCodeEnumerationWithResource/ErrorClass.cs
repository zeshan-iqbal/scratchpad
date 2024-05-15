namespace ErrorCodeEnumerationWithResource;

public enum ErrorClass : ushort
{
    /// <summary>
    /// Anything related to credentials.
    /// </summary>
    Rejected_Unauthenticated = 1,

    /// <summary>
    /// Anything related to permissions.
    /// </summary>
    Rejected_AccessDenied = 2,

    /// <summary>
    /// Anything related to the parameters, validation etc. 
    /// </summary>
    Invalid_BadRequest = 30,

    /// <summary>
    /// Anything related to business rules violation.
    /// </summary>
    Failed_BusinessViolation = 60,

    /// <summary>
    /// System maintenance.
    /// </summary>
    Failed_SystemMaintenance = 98,

    /// <summary>
    /// Anything which is not related to external party e.g. Business, Payer, Bank etc.
    /// </summary>
    Failed_SystemError = 99
}