using System;
using System.Collections.Generic;

namespace MastersWebApp.Models
{
    public partial class Ownership
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int DeviceId { get; set; }

        public virtual Device Device { get; set; } = null!;
        public virtual Client Owner { get; set; } = null!;
    }
}
