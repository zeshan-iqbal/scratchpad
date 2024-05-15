namespace ErrorCodeEnumerationWithResource;

public enum ActionHint : ushort
{
    /// <summary>
    /// Scenarios where retry is suggested.
    /// </summary>
    Retry = 1,

    /// <summary>
    /// Anything related to incorrect or invalid value.
    /// </summary>
    Correct = 2,

    /// <summary>
    /// Caller needs to take some action.
    /// </summary>
    Caller = 3,

    /// <summary>
    /// Payer needs to take some action.
    /// </summary>
    Payer = 4,

    /// <summary>
    /// System need to take some action (e.g. internal issues).
    /// </summary>
    System = 5,
}