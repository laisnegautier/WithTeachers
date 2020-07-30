using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace OnlineEducation.Data.Models
{
    public abstract class Activity
    {
        public int ActivityId { get; set; }

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

        public bool IsCompleted { get; set; } = false;

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        public bool IsOngoing { get; set; }

        //Host
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [NotMapped]
        public bool HasToOccurLater { get => ScheduledFor > DateTime.Now; }
    }

    public class Videoconference : Activity
    {
        public string RoomId { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        public bool HasPassword { get => !String.IsNullOrEmpty(Password); }

        public virtual ICollection<VideoconferenceUser> VideoconferenceUsers { get; set; }

        public bool PasswordIsCorrect(string passwordFromUser)
            => Password == passwordFromUser;

        public bool IsHost(ApplicationUser user)
            => user != null && User == user;
        
        //return true if the user is in list of users in the room
        public bool HasJoinedRoom(ApplicationUser user)
            => VideoconferenceUsers.Where(vcUser => vcUser.User == user) != null;
    }
}