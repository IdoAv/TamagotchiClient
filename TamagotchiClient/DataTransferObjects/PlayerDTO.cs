using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiClient.DataTransferObjects
{
    public class PlayerDTO
    {
        public int PlayerId { get; set; }
        public string PlayerEmail { get; set; }
        public string PlayerUserName { get; set; }
        public string PlayerGender { get; set; }
        public DateTime? PlayerBirthDate { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public int? PlayerActiveAnimal { get; set; }
        public string PlayerPassword { get; set; }

    }
}
