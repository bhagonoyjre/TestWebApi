using System;

namespace AppLibrary.ViewModels
{
    public class VendorReservationVM
    {
        public Guid Id { get; set; }
        public String VendorName { get; set; }
        public String Description { get; set; }
        public DateTime ReservationDate { get; set; }

    }
}