using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tutorial4
{
    public class CRUD
    {
        public string create(int id, string name, string role)
        {
            var record = new Employee
            {
                id = id,
                name = name,
                role = role
            };

            using (var db = new MyContext())
            {
                db.Add(record);
                db.SaveChanges();
            }

            return "Success";
        }

        public string read()
        {
            using (var db = new MyContext())
            {
                var data = from emp in db.employees
                           where emp.name.Contains("Mi")
                           select emp;

                foreach (var employee in data)
                {
                    employee.name = "nob head";
                    db.Update(employee);
                    

                    Console.WriteLine(employee.name);
                    Console.WriteLine(employee.role);
                }

                db.SaveChanges();
            }

            return "Success";
        }

        public string update(int id)
        {
            var employee = new Employee
            {
                id = id,
                name = "Test",
                role = "Test2"
            };

            using (var db = new MyContext())
            {
                db.Update(employee);
                db.SaveChanges();
            }

            return "Success";
        }

        public string delete(int id)
        {
            var employee = new Employee
            {
                id = id,
                name = "Test",
                role = "Test2"
            };

            using (var db = new MyContext())
            {
                db.Remove(employee);
                db.SaveChanges();
            }

            return "Success";
        }
    }
}
