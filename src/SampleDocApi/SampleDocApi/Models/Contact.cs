using System;

namespace SampleDocApi.Models
{
    /// <summary>
    /// Represents a Person
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Person's first name
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Person's last name (aka surname or family name)
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Date the person was born
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}