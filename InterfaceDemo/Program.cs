using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runners = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();

            runners.Add(person);
            runners.Add(animal);

            foreach (IRun runner in runners)
            {
                if (runner is IRun run)
                {
                    Console.WriteLine(runner);
                }
            }

            Console.WriteLine(runners.Count);

            Console.ReadLine();
        }

        public class Person: IRun
        {
            public string Name { get; set; }

            public void Run()
            {
                
            }
        }

        public class Animal: IRun
        {

            public string Name { get; set; }

            public void Run()
            {
                
            }
        }

        public interface IRun
        {
            void Run();
        }
    }
}
