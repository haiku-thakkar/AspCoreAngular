using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpMng.Models
{
    public class EmployeeDataAccessLayer
    {
        employeeDBContext db = new employeeDBContext();

        public IEnumerable<Employee> GetAllEmployees()
        {
            try
            {
                return db.Employee.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AddEmployee(Employee employee)
        {
            try
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public Employee GetEmployeeData(int id)
        {
            try
            {
                Employee employee = db.Employee.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        public int DeleteEmployee(int id)
        {
            try
            {
                Employee emp = db.Employee.Find(id);
                db.Employee.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public List<Qualification> GetQualifications()
        {
            List<Qualification> lstQualification = new List<Qualification>();
            lstQualification = (from QualificationList in db.Qualification select QualificationList).ToList();
            return lstQualification;
        }

        public List<Experience> GetExperiences()
        {
            List<Experience> lstExperience = new List<Experience>();
            lstExperience = (from ExperienceList in db.Experience select ExperienceList).ToList();
            return lstExperience;
        }

        public List<Language> GetLanguages()
        {
            List<Language> lstLanguage = new List<Language>();
            lstLanguage = (from LanguageList in db.Language select LanguageList).ToList();
            return lstLanguage;
        }
    }
}
