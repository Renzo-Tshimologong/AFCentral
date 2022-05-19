using System;
using AccessLayer;
namespace AfCentral
{
    class Program
    {
        static void Main(string[] args)
        {

            string con = "Server=sylvorenzo-Latitude-D630;Database=AfCentral; user=sa; password=Jacques@28";
            Access.Connect(con);

            Console.ReadLine();
        }
    }
}
