using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducation.Data.Models
{
    public class VideoconferenceUser
    {
        public int VideoconferenceUserId { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Connection> Connections { get; set; }
        public virtual ICollection<UserRoom> UserRooms { get; set; }
    }

    public class Connection
    {
        public string ConnectionId { get; set; }
        public string UserAgent { get; set; }
        public bool Connected { get; set; }
    }

    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public virtual ICollection<UserRoom> UserRooms { get; set; }
    }

    //Join table
    public class UserRoom
    {
        public int UserRoomId { get; set; }

        public int VideoconferenceUserId { get; set; }
        public virtual VideoconferenceUser VideoconferenceUser { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
