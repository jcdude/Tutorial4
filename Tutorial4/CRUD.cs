using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tutorial4
{
    public class CRUD
    {
        public Role createRole(int id, string name)
        {
            //Create a new isntance of the employee class
            //Set the property items to the arg passed to the method
            var record = new Role
            {
                id = id,
                name = name
            };

            //Declare a scope of the database context and added the enity then save it to the database
            using (var db = new MyContext())
            {
                db.Add(record);
                db.SaveChanges();
            }

            //Return a success string to display on the console
            return record;
        }
        public string create(int id, string name, int roleId)
        {
            //Create a new isntance of the employee class
            //Set the property items to the arg passed to the method
            var record = new Employee
            {
                id = id,
                name = name,
                roleId = roleId
            };

            //Declare a scope of the database context and added the enity then save it to the database
            using (var db = new MyContext())
            {
                db.Add(record);
                db.SaveChanges();
            }

            //Return a success string to display on the console
            return "Success";
        }

        public void read()
        {
            // Declare a scope of the database context
            using (var db = new MyContext())
            {
                //Get all the employees that contain Mi like the sql (LIKE %Mi%)
                var data = from emp in db.employees
                           where emp.name.Contains("Mi")
                           select emp;

                //loop the returned employees 
                foreach (var employee in data)
                {                    
                    //Write what is in the table to the console
                    Console.WriteLine(employee.name);
                    Console.WriteLine(employee.role);
                }
            }
        }

        public void update(int id, string name, Role role)
        {
            //Create a instance of the employee with a known id
            var employee = new Employee
            {
                id = id,
                name = name,
                role = role
            };

            //Set that instance for update 
            using (var db = new MyContext())
            {
                db.Update(employee);
                db.SaveChanges();

                Console.WriteLine(String.Concat("Updated employee ",employee.id));
            }
        }

        public void delete(int id)
        {
            //Create a instance of the employee with a known id
            var employee = new Employee
            {
                id = id
            };

            //Set that instance for update 
            using (var db = new MyContext())
            {
                db.Remove(employee);
                db.SaveChanges();

                Console.WriteLine(String.Concat("Deleted employee ", employee.id));
            }
        }
    }
}
