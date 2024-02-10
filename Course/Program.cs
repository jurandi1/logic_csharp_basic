using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------
            //AULA OPERADORES COMPARATIVOS EM C#
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("AULA OPERADORES COMPARATIVOS EM C#");
            Console.WriteLine("");

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("----------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            ////-------------------------------------------------------------------------------------------------
            ////AULA DE ENTRADA DE DADOS EM C#
            //Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("AULA DE ENTRADA DE DADOS EM C#");
            //Console.WriteLine("");

            //Console.WriteLine("P1 - Digite 4 informações para teste:");
            ////---------------------------
            //string frase = Console.ReadLine();
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //string s3 = Console.ReadLine();

            //Console.WriteLine("Digite 3 nomes com espaço para armazenamento em vetor exemplo (AMARELO LARANJA PRETO):");
            //string[] vet = Console.ReadLine().Split(' ');
            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);
            ////----------------------------------------
            //Console.WriteLine("P2 - Lendo diferentes tipos de variáveis:");
            ////string x6;
            //int y6;
            //double z6;
            //char w6;

            ////x6 = Console.ReadLine();
            //Console.Write("Digite um número inteiro: ");
            //y6 = int.Parse(Console.ReadLine());
            //Console.Write("Digite um carácter: ");
            //w6 = char.Parse(Console.ReadLine());
            //Console.Write("Digite um double: ");
            //z6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Digite nome, sexo, idade e altura. Exemplo:(Junior M 22 1.76): ");
            //string[] vet2 = Console.ReadLine().Split(' ');
            //string nome2 = vet2[0];
            //char sexo2 = char.Parse(vet2[1]);
            //int idade2 = int.Parse(vet2[2]);
            //double altura2 = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("Você digitou:");
            ////Console.WriteLine(x6);
            //Console.WriteLine(y6);
            //Console.WriteLine(w6);
            //Console.WriteLine(z6.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome2);
            //Console.WriteLine(sexo2);
            //Console.WriteLine(idade2);
            //Console.WriteLine(altura2.ToString("F2", CultureInfo.InvariantCulture));

            //Console.ReadLine();


            ////-------------------------------------------------------------------------------------------------
            ////AULA DE OPERAÇÕES ARITIMÉTICAS
            //Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("AULA DE OPERAÇÕES ARITIMÉTICAS");
            //Console.WriteLine("");

            //int op = 3 + 4 * 2;
            //int op2 = (3 + 4) * 2;
            //int op3 = 17 % 3;
            //double op4 = 10.0 / 8.0;

            //Console.WriteLine("3 + 4 * 2 = " + op);
            //Console.WriteLine("(3 + 4) * 2 = " + op2);
            //Console.WriteLine("17 % 3 = " + op3);
            //Console.WriteLine("10 / 8 = " + op4);
            ////-------------------------------------
            //Console.WriteLine("Calculando bascará:");
            //double a5 = 1.0, b5 = -3.0, c5 = -4.0;

            //double delta = Math.Pow(b5, 2) - 4.0 * a5 * c5;

            //double x2 = (-b5 + Math.Sqrt(delta)) / (2.0 * a5);
            //double x3 = (-b5 - Math.Sqrt(delta)) / (2.0 * a5);

            //Console.WriteLine("Delta: " + delta);
            //Console.WriteLine("Resultado + = " + x2);
            //Console.WriteLine("Resultado - = " + x3);

            ////-------------------------------------------------------------------------------------------------
            ////AULA DE CONVERSÃO IMPLÍCITA E CASTING
            //Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("AULA DE CONVERSÃO IMPLÍCITA E CASTING");
            //Console.WriteLine("");
            //Console.WriteLine("Implícita:");
            ////Converção implicita
            //float x1 = 4.5f;

            //double y = x1;

            //Console.WriteLine(y);
            ////--------------------
            ////Converção em casting
            //Console.WriteLine("Casting - double para float:");
            //double a1;
            //float b1;

            //a1 = 5.1;
            //b1 = (float)a1;
            //Console.WriteLine(b1);

            ////--------------------
            ////Converção em casting
            //Console.WriteLine("Casting double para int:");
            //double a2;
            //int b2;

            //a2 = 5.1;
            //b2 = (int)a2;

            //Console.WriteLine(b2);

            ////--------------------
            ////Converção em casting
            //Console.WriteLine("Casting int para double:");

            //int a3 = 5;
            //int b3 = 2;

            //double resultado = (double)a3 / b3;

            //Console.WriteLine(resultado);

            ////-------------------------------------------------------------------------------------------------
            ////AULA DE OPERADORES DE ATRIBUICOES
            //Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("AULA DE OPERADORES DE ATRIBUICAO");
            //Console.WriteLine("");

            //int a = 10;
            //Console.WriteLine(a);

            //a += 2;
            //Console.WriteLine(a);

            //a *= 3;
            //Console.WriteLine(a);

            //string s = "ABC";
            //Console.WriteLine(s);

            //s += "DEF";
            //Console.WriteLine(s);

            ////----------------------------
            //a = 10;
            //int b = ++a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            ////-------------------------------------------------------------------------------------------------
            ////AULA DE SAÍDA DE DADOS C#
            //Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("AULA DE SAÍDA DE DADOS C#");
            //Console.WriteLine("");

            //char genero = '\u004D';

            //int idade = 22;
            //double saldo = 3000.90;
            //string nome = "Junior";

            ////PLACEHOLDERS
            //Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais.", nome, idade, saldo);
            ////INTERPOLAÇÃO
            //Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2} reais.");
            ////CONCATENAÇÃO DE STRINGS
            //Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            //Console.WriteLine("AULA DE SAÍDA DE DADOS C#");

            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa tarde! :)");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("----------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            ////-------------------------------------------------------------------------------------------------
            //// AULA DE TIPOS DE DADOS EM C# - VARIAVEIS VALORES NUMÉRICOS
            //Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("AULA DE TIPOS DE DADOS EM C# - VARIAVEIS VALORES NUMÉRICOS");
            //Console.WriteLine("");

            //int int1 = int.MinValue;
            //int int2 = int.MaxValue;
            //sbyte sByte3 = sbyte.MinValue;
            //sbyte sByte4 = sbyte.MaxValue;
            //decimal dec5 = decimal.MaxValue;

            //Console.WriteLine(int1);
            //Console.WriteLine(int2);
            //Console.WriteLine(sByte3);
            //Console.WriteLine(sByte4);
            //Console.WriteLine(dec5);
            //Console.WriteLine("");

            //bool completo = false;
            //genero = 'F';
            //char letra = '\u004D';
            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483648L;
            //float n5 = 4.5F;
            //double n6 = 4.5;
            //nome = "Junior Green";
            //object obj1 = "Alex Brown";
            //object obj2 = 4.5F;

            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
            //sbyte x = 100;

            //Console.WriteLine(x);
        }
    }
}