using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using codemasters.Domain.Enums;

namespace codemasters.Domain.Entities.User
{
    public class UDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Username cannot be longer than 30 characters.")]
        public String Username { get; set; }

        //[Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password cannot be shorter than 8 characters.")]
        public String Password { get; set; }

        //[Required(ErrorMessage = "Email is required!")]
        [Required]
        [Display(Name = "Email Address")]
        [StringLength(30)]
        public String Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }

        [StringLength(30)]
        public String LasIp { get; set; }

        public URole Level { get; set; }

        // NEW
        //[Compare("Password", ErrorMessage = "Please, confirm your password!")]
        [DataType(DataType.Password)]
        public String Confirm { get; set; }
    }
}
