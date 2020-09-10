using RentACar.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Carbrand { get; set; }
        public string Carmodel { get; set; }
        public int Price { get; set; }
        public string Carimage { get; set; }
        public Gearbox Gearbox { get; set; }

        public RentaCarModel RentaCarModel { get; set; }
    }
}
