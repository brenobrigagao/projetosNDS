using System;

namespace Calculadora{
    class Program{
        static void Main(string[] args){
            menu();
        }
        static float lerFloat(){
            float variavel;
            while(!float.TryParse(Console.ReadLine(),out variavel)){
                Console.WriteLine("Entrada inválida!");
            }
            return variavel;
        }
        static float somar(float v1){
            float v2 = lerFloat();
            v1 += v2;
            Console.WriteLine(v1);
            return v1;
        }
        static float subtrair(float v1){
            float v2 = lerFloat();
            v1 -= v2;
            Console.WriteLine(v1);
            return v1;
        }
        static float multiplicar(float v1){
            float v2 = lerFloat();
            v1 *= v2;
            Console.WriteLine(v1);
            return v1;
        }
        static float dividir(float v1){
            float v2 = lerFloat();
            if(v2 == 0){
                Console.WriteLine("ERRO: Divisão por zero");
                return v1;
            }
            v1 /= v2;
            Console.WriteLine(v1);
            return v1;
        }
        static void menu(){
            int opcao;
            float valor = lerFloat();
            do{
            Console.WriteLine("1-SOMAR\n2-SUBTRAIR\n3-MULTIPLICAR\n4-DIVIDIR\n5-ZERAR\n6-SAIR");
            if(int.TryParse(Console.ReadLine(),out opcao)){
                switch(opcao){
                    case 1:
                    valor = somar(valor);
                    break;
                    case 2:
                    valor = subtrair(valor);
                    break;
                    case 3:
                    valor = multiplicar(valor);
                    break;
                    case 4:
                    valor = dividir(valor);
                    break;
                    case 5:
                    valor = 0;
                    break;
                    case 6:
                    Console.WriteLine("Saindo...");
                    break;
                    default:
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            }
            }while(opcao != 6);    
        }
    }

}