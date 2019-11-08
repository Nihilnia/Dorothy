using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass_02
{
    class Ego
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    static class Database
    {
        static Ego[] person;

        static Database()
        {
            // static Ego[] person = new Ego[3];
            person = new Ego[3];
            Ego person01 = new Ego() { ID = 1, Name = "Person_01" };
            person[0] = person01;

            person[1] = new Ego() { ID = 2, Name = "Person_02" };
            person[2] = new Ego() { ID = 3, Name = "Person_03" };
        }

        public static Ego[] AllPersons()
        {
            return person;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Ego[] personz = Database.AllPersons();

            foreach (var persona in personz)
            {
                Console.WriteLine($"ID: {persona.ID}, Name: {persona.Name}");
            }

            Console.Read();
        }
    }
}
