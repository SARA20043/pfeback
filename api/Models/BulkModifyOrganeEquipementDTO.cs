using System.Collections.Generic;

namespace PFE_PROJECT.Models
{
    public class BulkModifyOrganeEquipementDTO
    {
        public int ideqpt { get; set; }
        public List<OrganeModificationDTO> organes { get; set; } = new List<OrganeModificationDTO>();
    }

    public class OrganeModificationDTO
    {
        public int idorg { get; set; }
        public string numsérie { get; set; }
    }
} 