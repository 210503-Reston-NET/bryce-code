namespace RRUI
{
    /// <summary>
    /// Stdardized validation service for basic user input
    /// </summary>
    public interface IValidationService
    {
        /// <summary>
        /// Takes in a prompt and keeps asking that prompt until user returns a valid string
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
         string ValidateString(string prompt);
    }
}