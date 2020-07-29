﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineEducation.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Lastname { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }

    public class AnonymousUser
    {
        public string UserName { get; set; }

        public AnonymousUser() { }

        public AnonymousUser(string userName)
            => UserName = userName;
    }
}
