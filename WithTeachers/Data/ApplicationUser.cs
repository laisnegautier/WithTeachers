﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WithTeachers.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Lastname { get; set; }
    }
}
