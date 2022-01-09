using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapgeminiDDD.Common.Model;

namespace CapgeminiDDD.Infrastructrure.Repository
{
    public interface IRepository
    {
        Task<List<Student>> GetAllStudentsAsync();

        Task<Student> GetStudentsByIdAsync(int id);

        Task<Student> UpdateStudents(Student student);

        Task<Student> DeleteStudents(int id);

        Task<Student> CreateStudents(Student student);
    }
}