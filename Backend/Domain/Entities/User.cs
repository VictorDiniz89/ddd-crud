using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Aggregate of Fire Reports corresponding to a certain
    ///  location name, in a certain county.
    /// </summary>
    public class User : Entity
    {
        public string? title { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? role { get; set; }

        public User(int id, string title, string firstName, string lastName, string email, string role)
        {
            this.Id = id;
            this.title = title;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.role= role;
        }
        /// <summary>
        /// To be used by the de-serializer
        /// </summary>
        public User() { }

    }
}
