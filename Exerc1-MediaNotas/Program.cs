/*
Crie um aplicativo de console que peça ao usuário para inserir as notas de quatro provas. O programa deve recolher as 4 notas usando uma estrutura for, calcular a média das notas e usar uma estrutura if/else para determinar se o aluno passou (média >= 7), está de recuperação (média entre 5 e 6.9) ou reprovou (média < 5).
*/

using System;

namespace MediaEscolar {

public class Program {

    public static void Main(string[] args) {

        double[] notas = new double[4];
        double soma = 0;
        double media;

        Console.WriteLine("Insira as notas das provas");

        for(int i = 0; i < 4; i++) {

            Console.Write($"Nota da P{i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
            soma += notas[i];

        }

        media = soma / 4;

        if(media >= 7) {
            Console.WriteLine($"Aluno aprovado com média de {media}");
            
        } else if (media >= 5) {
            Console.WriteLine($"Em recuperação com média de {media}");

        } else {
            Console.WriteLine($"Aluno reprovado com média de {media}");
        }
    }

}
}