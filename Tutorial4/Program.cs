using System;

namespace Tutorial4
{
    class Program
    {
        static void Main(string[] args)
        {
            var crud = new CRUD();

            //Run this first as there will be no role to start with and it will fail to insert the employee
            //crud.createRole(1, "Role Name");

            crud.create(1,"Jed", 1);
            crud.create(2, "Mike", 1);
            //crud.create(3, "Seth", "the fool 3");

            crud.read();



            Console.ReadLine();
        }
    }
}
