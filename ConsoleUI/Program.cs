using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALApi;
using DO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IDal mydal = DalFactory.getDal();
            mydal.addStudent(new Student { Id = 111, Name = "Adina" });
            mydal.addStudent(new Student { Id = 222, Name = "Esther" });
        }
    }
}
