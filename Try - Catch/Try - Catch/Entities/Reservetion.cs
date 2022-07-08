using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try___Catch.Entities.Exceptions;

namespace Try___Catch.Entities
{
    internal class Reservetion
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }

        public DateTime CheckOut { get; set; }

        public Reservetion (int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("CheckOut esta mais antigo que o CheckIn");
            }

            RoomNumber = roomNumber;
            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Voce precisa atualizar as datas");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("CheckOut esta mais antigo que o CheckIn");
            }   
            
            Checkin = checkIn;
            CheckOut = checkOut;
            
        }
            

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + " ,check-in "
                + Checkin.ToString("dd/MM/yyyy")
                + " ,check-out "
                + CheckOut.ToString("dd/MM/yyyy")
                +" , "
                + Duration()
                + " nights";
        }
    }
}
