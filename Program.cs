using System;

namespace atributos_e_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();

            System.Console.WriteLine("Escolha seu personagem! [1] - Homem de ferro  ou  [2] - Coração de ferro");
            personagem.personagens = int.Parse(Console.ReadLine());

            switch(personagem.personagens)
            {
                case 1:
                    personagem.nome = "Tony Stark";
                    personagem.idade = 47;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine("Qual armadura deseja? [1] - Bledding Edge, [2] - MK 47 , [3] - MK 43)");
                    Console.ResetColor(); 

                    personagem.armadura = int.Parse(Console.ReadLine());

                        switch(personagem.armadura)
                        {
                            case 1:

                                System.Console.WriteLine($"Seu personagem é o {personagem.nome}, sua idade é {personagem.idade} e sua armadura é a Bledding Edge");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine("Deseja atacar o inimigo? [1] - Canhão de Energia , [2] - Repulsores da mão , [3] - Repulsor do peito ");
                                Console.ResetColor(); 

                                personagem.arma = int.Parse(Console.ReadLine());

                                switch(personagem.arma)
                                {
                                    case 1:
                                        System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com o Canhão de enrgia!");
                                    break;
                                    case 2:
                                         System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com os Repulsores das mãos");
                                    break;
                                    case 3:
                                        System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com o Repulsor do peito");
                                    break;
                                }
                            break;

                            case 2:
                                System.Console.WriteLine($"Seu personagem é o {personagem.nome}, sua idade é {personagem.idade} e sua armadura é a MK 47");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                 System.Console.WriteLine("Deseja atacar o inimigo?  [1] - Repulsores da mão , [2] - Repulsor do peito ");
                                Console.ResetColor(); 

                                personagem.arma = int.Parse(Console.ReadLine());

                                switch(personagem.arma)
                                {
                                    case 1:
                                        System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com os Repulsores das mãos");

                                    break;
                                    case 2:
                                         System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com o Repulsor do peito");
                                    break;
                                }
                            break;

                            case 3:

                                System.Console.WriteLine($"Seu personagem é o {personagem.nome}, sua idade é {personagem.idade} e sua armadura é a MK 43");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine("Deseja atacar o inimigo?  [1] - Repulsores da mão , [2] - Repulsor do peito ");
                                Console.ResetColor(); 

                                personagem.arma = int.Parse(Console.ReadLine());

                                switch(personagem.arma)
                                {
                                    case 1:
                                        System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com os Repulsores das mãos");
                                    break;

                                    case 2:
                                        System.Console.WriteLine($"{personagem.Atacar(personagem.arma)} com o Repulsor do peito");
                                    break;
                                }
                            break;
                        }
                break;

                case 2:
                    personagem.nome = "Morgan H Stark";
                    personagem.idade = 20;
                    personagem.armadura = int.Parse("Coração de Ferro"); 
                         
                    System.Console.WriteLine($"Seu personagem é o {personagem.nome}, sua idade é {personagem.idade} e sua armadura é a {personagem.armadura}"); 

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine("Deseja atacar o inimigo? [1] - Canhão de Energia , [2] - Repulsores da mão , [3] - Repulsor do peito ");
                    Console.ResetColor(); 

                    personagem.arma = int.Parse(Console.ReadLine());

                    switch(personagem.arma)
                    {
                        case 1:
                            System.Console.WriteLine(personagem.Atacar(personagem.arma));
                        break;
                        case 2:
                            System.Console.WriteLine(personagem.Atacar(personagem.arma));
                        break;
                        case 3:
                            System.Console.WriteLine(personagem.Atacar(personagem.arma));
                        break;
                    }  
 
                break;
            }
        }
    }
}
