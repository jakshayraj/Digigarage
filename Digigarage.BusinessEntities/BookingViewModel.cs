﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigarage.BusinessEntities
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        [Required]
        public Nullable<int> VehicleId { get; set; }
        [Required]
        public Nullable<int> ServiceId { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public Nullable<int> Status { get; set; }

        public virtual ServiceViewModel Service { get; set; }
        public virtual VehicleViewModel Vehicle { get; set; }
        public virtual StautsOfBookingViewModel StautsOfBooking { get; set; }
    }
}
