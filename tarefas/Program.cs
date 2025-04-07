using System;
using System.Collections.Generic;
using System.Linq;
namespace MyApp{
    
    public class Program{
        public static class Gerenciador{
            public static void Adicionar(List<String> lista, String tarefa){
                lista.Add(tarefa);
            }
            public static void Listar(List<String> lista){
                if(lista.Count == 0){
                    Console.WriteLine("Nenhuma tarefa foi listada ainda!");
                    return;
                }
                foreach(var (item, index) in lista.Select((valor, indice) => (valor,indice))){
                    Console.WriteLine($"{index+1}° tarefa:");
                    Console.WriteLine(item);
                }
            }
            public static void Remover(List<string> lista, int indice){
                if(indice < 1 || indice >  lista.Count){
                    Console.WriteLine("Indice inválido!");
                }
                lista.RemoveAt(indice - 1);
            }
        }
        public static void Main(string[] args){
            var tarefas = new List<string>();  
            int opcao;
            do{
            Console.WriteLine("1-Adicionar tarefa\n2-Excluir tarefa\n3-Listar tarefas\n4-Sair");
            Console.WriteLine("Escolha uma opção:");
            if(!int.TryParse(Console.ReadLine(), out opcao)){
                Console.WriteLine("Entrada inválida!");
                continue;  
                }
           switch(opcao){
            case 1:
                string? nova_tarefa;
                do{
                    Console.WriteLine("Digite uma nova tarefa:");
                    nova_tarefa = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(nova_tarefa)){
                        Console.WriteLine("ENtrada inválida!");
                    }
                }while(string.IsNullOrWhiteSpace(nova_tarefa));
                Gerenciador.Adicionar(tarefas, nova_tarefa);
                Console.WriteLine("Tarefa adicionada com sucesso!");
                break;
                case 2:
                Gerenciador.Listar(tarefas);
                if(tarefas.Count > 0){
                    if(int.TryParse(Console.ReadLine(),out int indice)){
                        Gerenciador.Remover(tarefas, indice);
                    }else{
                        Console.WriteLine("Entrada inválida!");
                    }    
                }
                break;
                case 3:
                    Console.WriteLine("Todas as tarefas listadas:");
                    Gerenciador.Listar(tarefas);
                    break;
                    case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;
                    default:
                    Console.WriteLine("Entrada inválida!");
                    break;
           } 
    }while(opcao != 4);}}}
