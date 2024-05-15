using System.Net;

namespace ErrorCodeEnumerationWithResource;

public enum ErrorCodes: ushort
{
    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToInitiateAuthentication = 16500,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToRequestAuthentication = 16501,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToProcessAuthentication = 16502,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToCompleteAuthentication = 16503,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToCancelAuthentication = 16504,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToErrorAuthentication = 16505,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToNotifyAuthentication = 16506,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToAuthorize = 16507,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToCapture = 16508,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToReverse = 16509,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToRefund = 16510,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedRequest = 16511,

    [ErrorCodeDetails("CanceledRequest", 16512, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_CanceledRequest = 16512,

    [ErrorCodeDetails("External_InvalidRequestData", 16513, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_InvalidRequestData = 16513,

    [ErrorCodeDetails("External_MissingRequiredField", 16515, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_MissingRequiredField = 16515,

    [ErrorCodeDetails("External_InvalidFieldValue", 16516, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_InvalidFieldValue = 16516,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToPerformFraudScreening = 16517,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToReviewFraud = 16518,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToPerformSaleOperation = 16519,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToResendToken = 16522,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToGetOffers = 16523,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToGetCards = 16524,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToCreateToken = 16527,

    [ErrorCodeDetails("External_Declined", 16528, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_Declined = 16528,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToRegister = 16529,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToGetCampaignOfferDetail = 16530,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_FailedToCancel = 16531,

    [ErrorCodeDetails("External_InvalidCard", 16532, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_InvalidCard = 16532,

    [ErrorCodeDetails("External_NotSupportedCardType", 16533, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_NotSupportedCardType = 16533,

    [ErrorCodeDetails("External_FraudManagerIsMisconfigured", 16534, ActionHint.Correct, ErrorClass.Failed_BusinessViolation, HttpStatusCode.BadRequest)]
    External_FraudManagerIsMisconfigured = 16534,

    // Reserved Codes: 16700-16799 - Critical
    [ErrorCodeDetails("External_GeneralFailure", 16700, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_GeneralFailure = 16700,

    [ErrorCodeDetails("External_CommunicationError", 16701, ActionHint.Retry, ErrorClass.Failed_SystemError, HttpStatusCode.BadRequest)]
    External_CommunicationError = 16701,

    [ErrorCodeDetails("External_CommunicationError", 16701, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.BadRequest)]
    External_Timeout = 16702,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_FailedToParseJsonObject = 16703,

    [ErrorCodeDetails("External_InvalidCredentials", 16500, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_InvalidCredentials = 16704,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_RjectedDueToSecurityReasons = 16705,

    [ErrorCodeDetails("External_InternalServerError", 16706, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_InternalServerError = 16706,

    [ErrorCodeDetails("SystemIsUnableToProcessResponse", 16500, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_FailedToParseXmlObject = 16707,

    // This error code is specific for reconciliation process when there is no record on external system.
    // In this case the error message should be related to communication error.
    [ErrorCodeDetails("External_CommunicationError", 16708, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_TransactionNotFoundForReconciliation = 16708,

    [ErrorCodeDetails("External_InvalidResponseData", 16709, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_InvalidResponseData = 16709,

    [ErrorCodeDetails("External_ExpiredCredentials", 16710, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_ExpiredCredentials = 16710,

    [ErrorCodeDetails("External_ResourceNotFound", 16711, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_ResourceNotFound = 16711,

    [ErrorCodeDetails("External_OabFailure", 16712, ActionHint.Payer, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_OabFailure = 16712,

    [ErrorCodeDetails("External_Misconfiguration", 16713, ActionHint.System, ErrorClass.Failed_SystemError, HttpStatusCode.InternalServerError)]
    External_Misconfiguration = 16713,

    //Message needs to be added by the exception creator.
    [ErrorCodeDetails("External_Failure", 16714, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_Failure = 16714,

    [ErrorCodeDetails("External_RefundNotAllowed", 16715, ActionHint.Correct, ErrorClass.Invalid_BadRequest, HttpStatusCode.BadRequest)]
    External_RefundNotAllowed = 16715,

    [ErrorCodeDetails("External_TimeoutOnExternalSystem", 16716, ActionHint.Retry, ErrorClass.Failed_SystemError, HttpStatusCode.BadRequest)]
    External_TimeoutOnExternalSystem = 16716,

    [ErrorCodeDetails("External_DeniedByRisk", 16717, ActionHint.Retry, ErrorClass.Failed_SystemError, HttpStatusCode.BadRequest)]
    External_DeniedByRisk = 16717,

    [ErrorCodeDetails("External_ExpiredRequest", 16718, ActionHint.Retry, ErrorClass.Failed_SystemError, HttpStatusCode.BadRequest)]
    External_ExpiredRequest = 16718,
}