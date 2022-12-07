using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_entity_framework.Core.Models
{
    internal class ReservationBook
    {
        private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservations;

        public ReservationBook(Dictionary<RoomID, List<Reservation>> roomsToReservations)
        {
            _roomsToReservations = roomsToReservations;
        }
    }
}
