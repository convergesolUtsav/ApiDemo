using ES.Domain.Entities;
using ES.Repository.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpGet("Studentlist")]
        public async Task<ActionResult> StudentList()
        {
            List<Student> students = await _studentRepository.GetAll();
            return Ok(students);
        }
        [HttpPost("Create")]
        public async Task<ActionResult> Create(Student student)
        {
            int data = await _studentRepository.Add(student);
            return Ok(data);
        }

        [HttpPost("Delete")]
        public async Task<ActionResult> Delete(Student student)
        {
            int data = await _studentRepository.Add(student);
            return Ok(data);
        }
    }
}
