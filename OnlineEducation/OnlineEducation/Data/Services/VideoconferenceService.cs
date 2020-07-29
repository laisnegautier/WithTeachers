using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineEducation.Data;
using OnlineEducation.Data.Models;

namespace OnlineEducation.Data.Services
{
    public class VideoconferenceService
    {
        private readonly ApplicationDbContext _context;

        public VideoconferenceService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Videoconference> CreateAsync(Videoconference videoconference)
        {
            _context.Videoconferences.Add(videoconference);
            await _context.SaveChangesAsync();
            return videoconference;
        }

        public async Task<Videoconference> ReadAsync(int id)
            => await _context.Videoconferences.SingleOrDefaultAsync(x => x.ActivityId == id);


        public async Task<Videoconference> GetByRoomAsync(string roomId)
            => await _context.Videoconferences.SingleOrDefaultAsync(x => x.RoomId == roomId);
    }
}
