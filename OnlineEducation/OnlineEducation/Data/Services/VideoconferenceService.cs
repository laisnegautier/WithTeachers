using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineEducation.Data;
using OnlineEducation.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace OnlineEducation.Data.Services
{
    public class VideoconferenceService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VideoconferenceService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<Videoconference> CreateAsync(Videoconference videoconference)
        {
            _context.Videoconferences.Add(videoconference);
            await _context.SaveChangesAsync();
            return videoconference;
        }

        public async Task<Videoconference> ReadAsync(int id)
        { 
            return await _context.Videoconferences.SingleOrDefaultAsync(x => x.ActivityId == id); 
        }


        public async Task<Videoconference> GetByRoomAsync(string roomId)
            => await _context.Videoconferences.SingleOrDefaultAsync(x => x.RoomId == roomId);

        public async Task UpdateAsync(Videoconference vc)
        {
            _context.Entry(vc).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<VideoconferenceUser> AddToRoom(Videoconference videoconference, ApplicationUser user)
        {
            VideoconferenceUser vuToAdd = new VideoconferenceUser()
            {
                UserId = user.Id,
                VideoconferenceActivityId = videoconference.ActivityId
            };

            _context.VideoconferenceUsers.Add(vuToAdd);
            await _context.SaveChangesAsync();
            return vuToAdd;
        }
    }
}
