using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpMng.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpMng.Controllers
{
    
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();


        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<Employee> Index()
        {
            return objemployee.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create([FromBody] Employee employee)
        {
            return objemployee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public Employee Details(int id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit([FromBody]Employee employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("api/Employee/GetQualificationList")]
        public IEnumerable<Qualification> QualificationDetails()
        {
            return objemployee.GetQualifications();
        }

        [HttpGet]
        [Route("api/Employee/GetExperienceList")]
        public IEnumerable<Experience> ExperienceDetails()
        {
            return objemployee.GetExperiences();
        }

        [HttpGet]
        [Route("api/Employee/GetLanguageList")]
        public IEnumerable<Language> LanguageDetails()
        {
            return objemployee.GetLanguages();
        }
    }
}
