using System;
using System.ComponentModel.DataAnnotations;

namespace EEDev_IDE.Data.Models
{
   
    internal static class UserModel
    {
        [Key]
        public static string Email { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }

        public static bool GitHub { get; set; }
        public static bool Twitter { get; set; }
        public static bool Facebook { get; set; }

    }
}
