using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class RentaCarModel
    {
        // her modelin unique bir id si olur.
        public int Id { get; set; }

        //aracı teslim alma tarihi
        public DateTime PickupDate { get; set; }

        //aracı teslim etme tarihi
        public DateTime DeliveryDate { get; set; }

        //toplam ödenecek ücret
        public int TotalPrice { get; set; }


        // İlişkiler

        // bir kirlama işleminin bir kullanıcısı olur. (one to one relations)
        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public int CarId { get; set; }
        public CarModel CarModel { get; set; }

    }
}
