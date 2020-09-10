using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class RegisterViewModel : UserModel
    {

        [DataType(DataType.Password), Compare(nameof(Password),ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
