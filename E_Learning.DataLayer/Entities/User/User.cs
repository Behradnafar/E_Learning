using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Learning.DataLayer.Entities.User
{
    public class User
    {
        public User()
        {

        }


        [Key]
        public int UserId { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter {0}.")]
        [MaxLength(200, ErrorMessage = "{0} Not more than {1} characters.")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter {0}.")]
        [MaxLength(200, ErrorMessage = "{0} Not more than {1} characters.")]
        [EmailAddress(ErrorMessage = "Invalid Email address.")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter {0}.")]
        [MaxLength(200, ErrorMessage = "{0} Not more than {1} characters.")]
        public string Password { get; set; }

        [Display(Name = "Activation Code")]
        [MaxLength(50, ErrorMessage = "{0} Not more than {1} characters.")]

        public string ActiveCode { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Avatar")]
        [MaxLength(200, ErrorMessage = "{0} Not more than {1} characters.")]

        public string UserAvatar { get; set; }

        [Display(Name = "Register Date")]
        public DateTime RegisterDate { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion  

    }
}
