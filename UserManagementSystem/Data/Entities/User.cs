using Microsoft.AspNetCore.Identity;
using System;

namespace UserManagementSystem.Data.Entities
{
    public class User : IdentityUser
    {
        public DateTime? BirthDate { get; set; }
    }
}
