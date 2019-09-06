using System;

namespace Tutorial4
{
    class Program
    {
        static void Main(string[] args)
        {
            var crud = new CRUD();
            crud.create(1,"Jed","the fool");
            crud.create(2, "Mike", "the fool 2");
            //crud.create(3, "Seth", "the fool 3");

            crud.read();



            Console.ReadLine();
        }
    }
}
