using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [StringLength(1)]
        public string RoleName { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        public ICollection<Admin> Admins { get; set; }
    }
}
