using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiClient.DataTransferObjects
{
    public class AnimalDTO
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public DateTime AnimalBirthDate { get; set; }
        public double AnimalWeight { get; set; }
        public double AnimalAge { get; set; }
        public int AnimalHunger { get; set; }
        public int AnimalCleaness { get; set; }
        public int AnimalHappiness { get; set; }
        public string StatusName { get; set; }
        public string LifeCycleName { get; set; }
        public int PlayerId { get; set; }

       
    }
}
