using System.Collections.Generic;

namespace PFE_PROJECT.Models
{
    public class BulkModifyCaracteristiqueEquipementDTO
    {
        public int ideqpt { get; set; }
        public List<CaracteristiqueModificationDTO> caracteristiques { get; set; } = new List<CaracteristiqueModificationDTO>();
    }

    public class CaracteristiqueModificationDTO
    {
        public int idcarac { get; set; }
        public string valeur { get; set; }
    }
} 