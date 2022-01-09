using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapgeminiDDD.Common.Model;
using Microsoft.EntityFrameworkCore;

namespace CapgeminiDDD.Infrastructrure.Repository
{
    public class StudentRepository : IRepository
    {
        private StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            this._context = context;
        }

        public async Task<Student> CreateStudents(Student student)
        {
            _context.Add(student);

            _context.SaveChanges();

            return student;
        }

        public Task<Student> DeleteStudents(int id)
        {
            Task<Student> student = _context.Student.FirstOrDefaultAsync(e => e.Id == id);
            if (student != null)
            {
                _context.Remove(student);
                _context.SaveChanges();
            }
            return student;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<Student> GetStudentsByIdAsync(int id)
        {
            Task<Student> student = _context.Student.FirstOrDefaultAsync(e => e.Id == id);
            if (student != null)
            {
                return await student;
            }
            return null;
        }

        public async Task<Student> UpdateStudents(Student student)
        {
            if (student != null)
            {
                _context.Update(student);
                _context.SaveChanges();
            }
            return student;
        }
    }
}