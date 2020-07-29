using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public abstract class Activity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The activity title should not be left empty.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The activity description should not be left empty.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The scheduled activity date should be selected.")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledFor { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan TimeSpan { get; set; }

        public bool Completed { get; set; } = false;

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        public bool Ongoing { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    public class Videoconference : Activity
    {
        public string Slug { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class ClassActivity : Activity
    {
        public string ClassId { get; set; }
        public virtual Class Class { get; set; }
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