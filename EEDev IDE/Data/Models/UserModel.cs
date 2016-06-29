using System;
using System.ComponentModel.DataAnnotations;

namespace EEDev_IDE.Data.Models
{
    [Serializable]
    internal class UserModel
    {
        [Key]
        public string Email { get; set; }
        public string Name { get; set; }        
        public string Password { get; set; }

        public bool GitHub { get; set; }
        public bool Twitter { get; set; }
        public bool Facebook { get; set; }

    }
}
