using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Contract
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public int MasterId { get; set; }
        public string Date { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;
        public virtual Master Master { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
