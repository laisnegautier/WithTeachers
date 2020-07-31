using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineEducation.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Lastname { get; set; }
        public string Pseudo { get; set; }

        public bool IsAnonymous { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<VideoconferenceUser> VideoconferenceUsers { get; set; }
    }

    //Join table
    public class VideoconferenceUser
    {
        public int VideoconferenceUserId { get; set; }

        public int VideoconferenceActivityId { get; set; }
        public virtual Videoconference Videoconference { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<SignalRConnection> Connections { get; set; }

        [NotMapped]
        public bool IsConnected
        {
            // check if there's at least one active connection
            get => Connections.FirstOrDefault(co => co.Connected) != null;
        }
    }

    public class SignalRConnection
    {
        public int SignalRConnectionId { get; set; }
        public string ConnectionId { get; set; }
        public string UserAgent { get; set; } //browser
        public bool Connected { get; set; }

        public virtual VideoconferenceUser VideoconferenceUser { get; set; }
    }
}
