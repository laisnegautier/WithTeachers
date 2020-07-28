using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Videoconference
    {
        public string VideoconferenceId { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Ongoing { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    //Used for the hub
    public class UserCall
    {
        public List<User> Users;
    }

    public class User
    {
        public string Username;
        public string ConnectionId;
        public bool InCall;
    }

    public class CallOffer
    {
        public User Caller;
        public User Callee;
    }
}