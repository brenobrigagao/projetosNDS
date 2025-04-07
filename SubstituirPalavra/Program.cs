using System;

namespace MyApp{
    class Program{
        static void Main(string[] args){
            string? texto;
            Console.WriteLine("Digite uma frase:");
            while(string.IsNullOrWhiteSpace(texto = Console.ReadLine())){
                Console.WriteLine("Entrada inválida!");
            }
            bool presente;
            var dividido = texto.Split(' ');
            string? palavra;
            do{
            Console.WriteLine("Escolha uma palavra que você quer substituir no texto");
            while(string.IsNullOrWhiteSpace(palavra = Console.ReadLine())){
                Console.WriteLine("Entrada inválida!");
            }
            presente = Array.Exists(dividido, p => p == palavra);
            if(!presente){
                Console.WriteLine("A palavra não está presente no texto!");
            }
            }while(!presente);
            Console.WriteLine("Escolha a nova palavra:");
            string? novaPalavra;
            while(string.IsNullOrWhiteSpace(novaPalavra = Console.ReadLine())){
                Console.WriteLine("Entrada inválida!");
            }
            texto = texto.Replace(palavra,novaPalavra);   
            Console.WriteLine($"Frase modificada: {texto}");
        }
    }
}
