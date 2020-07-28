using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WithTeachers.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Lastname { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Videoconference> Videoconferences { get; set; }
    }

    public class AnonymousUser
    {
        public string UserName { get; set; }

        public AnonymousUser() { }

        public AnonymousUser(string userName)
            => UserName = userName;
    }
}
