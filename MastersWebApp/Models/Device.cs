using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Device
    {
        public Device()
        {
            Ownerships = new HashSet<Ownership>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Breakage { get; set; } = null!;
        public string Model { get; set; } = null!;

        public virtual ICollection<Ownership> Ownerships { get; set; }
    }
}
