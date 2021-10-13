namespace SampleDocApi
{
    /// <summary>
    /// This is test Record type
    /// </summary>
    public record RecordTest
    {
        /// <summary>
        /// What is your first name?
        /// </summary>
        public string FirstName { get; set; } = default!;
        
        /// <summary>
        /// What is your last name (surname, family name)
        /// </summary>
        public string LastName { get; set; } = default!;
    }
}