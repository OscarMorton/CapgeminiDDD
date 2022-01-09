using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapgeminiDDD.Common.Model;
using CapgeminiDDD.Infrastructrure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CapgeminiDDD.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public IRepository _repository { get; set; }

        public StudentController(IRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _repository.GetAllStudentsAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Student> GetStudentById(int id)
        {
            return await _repository.GetStudentsByIdAsync(id);
        }

        [HttpPost]
        [Route("Create")]
        public async void CreateStudent(Student student)
        {
            await _repository.CreateStudents(student);
        }

        [HttpPut]
        [Route("Update")]
        public async void UpdateStudent(Student student)
        {
            await _repository.UpdateStudents(student);
        }

        [HttpGet]
        [Route("Delete{id}")]
        public async void DeleteStudentById(int id)
        {
            await _repository.DeleteStudents(id);
        }
    }
}