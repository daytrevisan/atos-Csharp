/*
Implemente um jogo simples onde o programa escolhe um número aleatório entre 1 e 10, e o usuário tem que adivinhar qual é esse número. Use um loop while ou for para dar ao usuário três tentativas para acertar o número. Se ele acertar, o programa parabeniza o usuário; se não, o programa revela o número e termina.
*/

using System;

namespace JogoDaAdvinhacao {

    public class Program {
        public static void Main(string[] args) {

            Random randomico = new Random();
            int aleatorio = randomico.Next(1, 11);
            Console.WriteLine(aleatorio.ToString());

            int tentativas = 3;

            for(int i=0; i<tentativas; i++) {

                Console.Write("Chute um número: ");
                int chute = int.Parse(Console.ReadLine());

                if(chute == aleatorio) {
                    Console.WriteLine("ACERTOU!!!");
                    return;
                } else {
                    Console.WriteLine("Errou! Tente novamente.");
                }

            }

            Console.WriteLine("Suas chances acabaram!");

        }

    }

}