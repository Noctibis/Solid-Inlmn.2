using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{

    internal class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        

        internal IFactory GetFactory(string typeOfFactory)
        {
            if (typeOfFactory == "Cat")
            {
                return new CatFactory();
            }
            else if (typeOfFactory == "Dog")
            {
                return new DogFactory();
            }
            return null;
        }

        public void Run()
        {
            IFactory factory = GetFactory("Cat");            
            IAnimal animal = factory.CreateAnimal("gdzjhdhgs");
            Console.WriteLine(animal.Name);

        }
    }
}
