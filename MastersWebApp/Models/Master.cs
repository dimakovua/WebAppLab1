using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Master
    {
        public Master()
        {
            Contracts = new HashSet<Contract>();
            Specializations = new HashSet<Specialization>();
        }

        public int Id { get; set; }
        public int HumanId { get; set; }
        public string WorkingStart { get; set; } = null!;
        public int Salary { get; set; }

        public virtual Human Human { get; set; } = null!;
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
