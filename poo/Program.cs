using System;

namespace MyApp
{
    public class Animal
    {
     
        private string Cor;
        private string Raca;

        public virtual void Barulho() 
        {
            Console.WriteLine("O animal faz um som.");
        }
    }

    public class Cachorro : Animal
    {
        public override void Barulho()
        {
            Console.WriteLine("Au, Au!");
        }
    }

    public class Gato : Animal
    {
        public override void Barulho()
        {
            Console.WriteLine("Miau, Miau!");
        }
    }

    public class Program
    {
        public static void Main(string[] args) 
        {
            Animal meuCachorro = new Cachorro();
            Animal meuGato = new Gato();
            
            meuCachorro.Barulho(); 
            meuGato.Barulho(); 
    }
}
}
