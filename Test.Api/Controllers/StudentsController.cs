using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Api.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        List<Student> _student = new List<Student>();

        public StudentsController()
        {
            _student = new List<Student>();

            for (int i = 0; i < 9; i++)
            {
                _student.Add(
                        new Student {   
                            Name = $"Name {i}", 
                            Roll = $"Roll {i}", 
                            StudentId = i });
            }
        }


        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _student;
        }

    }
}
