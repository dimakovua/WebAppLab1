using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Service
    {
        public Service()
        {
            Contracts = new HashSet<Contract>();
            Specializations = new HashSet<Specialization>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Time { get; set; } = null!;
        public int? Cost { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
