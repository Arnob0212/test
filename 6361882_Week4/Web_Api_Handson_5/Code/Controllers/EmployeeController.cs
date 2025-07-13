using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using EmployeeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John Doe",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(1990, 1, 1),
                Department = new Department { Id = 1, Name = "HR" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "Communication" },
                    new Skill { Id = 2, Name = "Recruitment" }
                }
            },
            new Employee
            {
                Id = 2,
                Name = "Jane Smith",
                Salary = 70000,
                Permanent = false,
                DateOfBirth = new DateTime(1985, 5, 23),
                Department = new Department { Id = 2, Name = "Finance" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "Accounting" },
                    new Skill { Id = 4, Name = "Excel" }
                }
            }
        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(_employees);
        }

        [HttpPost]
        public ActionResult AddEmployee([FromBody] Employee employee)
        {
            _employees.Add(employee);
            return Ok(employee);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> UpdateEmployee([FromBody] Employee updatedEmp)
        {
            if (updatedEmp == null)
                return BadRequest("No data provided");

            if (updatedEmp.Id <= 0)
                return BadRequest("Invalid employee id");

            var emp = _employees.FirstOrDefault(e => e.Id == updatedEmp.Id);

            if (emp == null)
                return BadRequest("Invalid employee id");

            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.Department = updatedEmp.Department;
            emp.Skills = updatedEmp.Skills;
            emp.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(emp);
        }
    }
}
