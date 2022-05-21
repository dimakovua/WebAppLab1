using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Client
    {
        public Client()
        {
            Contracts = new HashSet<Contract>();
            Ownerships = new HashSet<Ownership>();
        }

        public int Id { get; set; }
        public int HumanId { get; set; }
        public string Card { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual Human Human { get; set; } = null!;
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Ownership> Ownerships { get; set; }
    }
}
