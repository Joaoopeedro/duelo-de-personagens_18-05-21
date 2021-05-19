using System;

namespace duelo_personagens
{
    class Program
    {
        static void Main(string[] args)
        {
             Personagens personagem1 = new Personagens();
            Personagens personagens2 = new Personagens();

            Console.WriteLine("DUELO DE PERSONAGEM");
            Console.WriteLine("!ESCOLHA 2 PERSONAGEMS QUE VOCÊ DESEJA UTILIZAR!");

            Console.WriteLine("");
            Console.WriteLine("");



            Console.WriteLine("PERSOANGEM 1");
            Console.WriteLine("Qual o nome do personagem que você deseja usar??");
            personagem1.nome = Console.ReadLine();

            Console.WriteLine("Qual idade do seu personagem ?");
            personagem1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a armadura do seu personagem ??");
            personagem1.armadura = Console.ReadLine();

            do
            {

                Console.WriteLine("Digite a vida que seu personagem deseja ter: de (0/100)");
                personagem1.pontoVida = int.Parse(Console.ReadLine());

                if (personagem1.pontoVida > 100)
                {
                    Console.WriteLine("!Vida esta alem do desejado!");

                }
                
            } while (personagem1.pontoVida > 100);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("PERSOANGEM 2");
            Console.WriteLine("Qual o nome do personagem que você deseja usar??");
            personagens2.nome = Console.ReadLine();
            Console.WriteLine("Qual idade do seu personagem ?");
            personagens2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a armadura do seu personagem ??");
            personagens2.armadura = Console.ReadLine();
            
            do
            {

                Console.WriteLine("Digite a vida que seu personagem deseja ter: de (0/100)");
                personagens2.pontoVida = int.Parse(Console.ReadLine());

                if (personagens2.pontoVida > 100)
                {
                    Console.WriteLine("!Vida esta alem do desejado!");

                }
                
            } while (personagens2.pontoVida > 100);



            do
            {


                Console.Clear();
                Console.WriteLine($@"
Selecione a opção do personagem 1
      1- Atacar
      2- Defender
      3- Restaurar armadura");

                int opçãoP1 = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($@"
Selecione a opção do personagem 2
      1- Atacar
      2- Defender
      3- Restaurar armadura");

                int opçãoP2 = int.Parse(Console.ReadLine());

                if (opçãoP1 == 1 && opçãoP2 == 1)
                {
                    personagem1.pontoVida = personagem1.pontoVida - personagens2.Atacar();

                    personagens2.pontoVida = personagens2.pontoVida - personagem1.Atacar();
                }
                else if (opçãoP1 == 1 && opçãoP2 == 2)
                {
                    personagens2.pontoVida = personagens2.pontoVida - (personagem1.Atacar() - personagens2.Defender());


                }
                else if (opçãoP1 == 1 && opçãoP2 == 3)
                {
                    personagens2.pontoVida = personagens2.pontoVida + (personagens2.Restaurar() - personagem1.Atacar());
                }
                else if (opçãoP1 == 2 && opçãoP2 == 1)
                {
                    personagem1.pontoVida = personagem1.pontoVida - (personagens2.Atacar() - personagem1.Defender());
                }
                else if (opçãoP1 == 2 && opçãoP2 == 2)
                {

                    Console.WriteLine("Os personagens ficaram se encarando de maneira estranha");
                }
                else if (opçãoP1 == 2 && opçãoP2 == 3)
                {
                    personagens2.pontoVida = personagens2.pontoVida + personagens2.Restaurar();
                }

                else if (opçãoP1 == 3 && opçãoP2 == 1)
                {
                    personagem1.pontoVida = personagem1.pontoVida + (personagem1.Restaurar() - personagens2.Atacar());

                }
                else if (opçãoP1 == 3 && opçãoP2 == 2)
                {
                    personagem1.pontoVida = personagem1.pontoVida + personagem1.Restaurar();
                }
                else if (opçãoP1 == 3 && opçãoP2 == 3)
                {
                    personagem1.pontoVida = personagem1.pontoVida + personagem1.Restaurar();
                    personagens2.pontoVida = personagens2.pontoVida + personagens2.Restaurar();
                }
                
                



                Console.WriteLine($"Vida do {personagem1.nome} esta de {personagem1.pontoVida} ");
                Console.WriteLine($"Vida do  {personagens2.nome} esta de {personagens2.pontoVida}");

            } while (personagem1.pontoVida > 0 && personagens2.pontoVida > 0);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER !!!");
        
        }
    }
}
