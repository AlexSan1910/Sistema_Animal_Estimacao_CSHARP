using Exercicios;

namespace AnimalEstimacao{
    public class Program{
        static void Main(string[] args){
            
            // Instanciando objetos com seus respectivos valos de cada propriedade de acordo com os construtores

            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();

            // Contadores para os animais
            int contCachorro = 0;
            int contGato = 0;
            int contPeixe = 0;

            // Primeiro Animal

            Console.Write("Digite o nome do seu primeiro animal: ");
            a1.Nome = Console.ReadLine();

            Console.Write("Digite o tipo do seu primeiro animal: ");
            a1.TipoAnimal = Console.ReadLine();

            if (a1.TipoAnimal == "cachorro"){
                contCachorro++;
            } else if (a1.TipoAnimal == "gato"){
                contGato++;
            } else if(a1.TipoAnimal == "peixe"){
                contPeixe++;
            }

            // Segundo Animal

            Console.Write("Digite o nome do seu segundo animal: ");
            a2.Nome = Console.ReadLine();

            Console.Write("Digite o tipo do seu segundo animal: ");
            a2.TipoAnimal = Console.ReadLine();

            if (a2.TipoAnimal == "cachorro"){
                contCachorro++;
            } else if (a2.TipoAnimal == "gato"){
                contGato++;
            } else if(a2.TipoAnimal == "peixe"){
                contPeixe++;
            }

            // Terceiro Animal

            Console.Write("Digite o nome do seu terceiro animal: ");
            a3.Nome = Console.ReadLine();

            Console.Write("Digite o tipo do seu Terceiro animal: ");
            a3.TipoAnimal = Console.ReadLine();

            if (a3.TipoAnimal == "cachorro"){
                contCachorro++;
            } else if (a3.TipoAnimal == "gato"){
                contGato++;
            } else if(a3.TipoAnimal == "peixe"){
                contPeixe++;
            }

            // Quarto Animal

            Console.Write("Digite o nome do seu Quarto animal: ");
            a4.Nome = Console.ReadLine();

            Console.Write("Digite o Tipo do seu Quarto animal: ");
            a4.TipoAnimal = Console.ReadLine();

            if (a4.TipoAnimal == "cachorro"){
                contCachorro++;
            } else if (a4.TipoAnimal == "gato"){
                contGato++;
            } else if(a4.TipoAnimal == "peixe"){
                contPeixe++;
            }

            // Quinto Animal

            Console.Write("Digite o nome do seu Quinto animal: ");
            a5.Nome = Console.ReadLine();

            Console.Write("Digite o tipo do seu Quinto animal: ");
            a5.TipoAnimal = Console.ReadLine();

            if (a5.TipoAnimal == "cachorro"){
                contCachorro++;
            } else if (a5.TipoAnimal == "gato"){
                contGato++;
            } else if(a5.TipoAnimal == "peixe"){
                contPeixe++;
            }

            Console.WriteLine("\n Total dos seus animais de estimação:");
            Console.WriteLine($"Quantidade de cachorros {contCachorro}, quantidade de Gatos {contGato}, quantidade de Peixes {contPeixe}");

        }
    }
}