using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Human
    {
        public Human()
        {
            Clients = new HashSet<Client>();
            Masters = new HashSet<Master>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Master> Masters { get; set; }
    }
}
