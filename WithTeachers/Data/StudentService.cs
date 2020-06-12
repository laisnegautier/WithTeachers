using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    /// <summary>
    /// CRUD for Student
    /// </summary>
    public class StudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Student> CreateAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> ReadAllAsync(Class cl)
            => await _context.Students.Where(x => x.Class == cl).OrderBy(x => x.Lastname).ToListAsync();


        public async Task Delete(Student student)
        {
            Student studentExists = await _context.Students.SingleOrDefaultAsync(x => x.StudentId == student.StudentId);
            if (studentExists != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}
