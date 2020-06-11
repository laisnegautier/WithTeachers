using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class ClassService
    {    
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        private AuthenticationStateProvider AuthenticationStateProvider { get; }

        public ClassService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<Class>> GetAllAsync()
        {
            return await _context.Classes.ToListAsync();
        }

        public async void Create(Class cl) 
        {
            _context.Classes.Add(cl);
            await _context.SaveChangesAsync();
            //return toDo;
        }
    }
}
