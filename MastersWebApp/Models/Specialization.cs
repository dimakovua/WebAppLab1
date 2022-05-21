using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Specialization
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int ServiceId { get; set; }

        public virtual Master Master { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
