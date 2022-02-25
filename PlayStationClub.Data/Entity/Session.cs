using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStationClub.Data.Entity
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public byte PlayerNumber { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
