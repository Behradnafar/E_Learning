using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Learning.DataLayer.Entities.User
{
    public class Role
    {
        public Role()
        {

        }

        [Key]
        public int RoleId { get; set; }
        [Display(Name = "RoleTitle")]
        [Required(ErrorMessage = "Please enter {0}.")]
        [MaxLength(200, ErrorMessage = "{0} Not more than {1} characters.")]
        public string RoleTitle { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion  
    }
}
