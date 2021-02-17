using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigarage.BusinessEntities
{
    public class VehicleViewModel
    {
        public int VehicleId { get; set; }
        [Required]
        [DisplayName("Licence Plate No")]
        public string LicencePlate { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public Nullable<System.DateTime> RegistraionDate { get; set; }
        [Required]
        public string ChassiNo { get; set; }
        [Required]
        public string EngineNo { get; set; }
        [Required]
        public Nullable<int> CustomerId { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
    }
}
