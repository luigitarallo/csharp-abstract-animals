using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("Zzzzzz");
        }

        public abstract void Verso();
        public abstract void Mangia();
        public abstract void CheAnimale();
    }

    public class Cane : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Faccio bau bau!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangio crocchette e carne");
        }

        public override void CheAnimale()
        {
            Console.WriteLine("Sono un cane!");
        }
    }

    public class Passerotto : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Faccio cip cip!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangio insetti e frutta");
        }

        public override void CheAnimale()
        {
            Console.WriteLine("Sono un passerotto!");
        }
    }

    public class Aquila : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Faccio screech!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangio piccoli mammiferi");
        }

        public override void CheAnimale()
        {
            Console.WriteLine("Sono un'aquila!");
        }
    }

    public class Delfino : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Faccio click click!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangio pesci");
        }

        public override void CheAnimale()
        {
            Console.WriteLine("Sono un delfino!");
        }
    }
}
