using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_entity_framework.Core.Models
{
    internal class Reservation
    {
        public RoomID RoomID { get; }
        public DateOnly StartDate { get; }
        public DateOnly EndTime { get; }

        public Reservation(RoomID roomID, DateOnly startDate, DateOnly endTime)
        {
            RoomID = roomID;
            StartDate = startDate;
            EndTime = endTime;
        }
    }
}
