using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------
            //AULA DE OPERADORES DE ATRIBUICOES
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("AULA DE OPERADORES DE ATRIBUICAO");
            Console.WriteLine("");

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            //----------------------------
            a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //-------------------------------------------------------------------------------------------------
            //AULA DE SAÍDA DE DADOS C#
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("AULA DE SAÍDA DE DADOS C#");
            Console.WriteLine("");

            char genero = '\u004D';

            int idade = 22;
            double saldo = 3000.90;
            string nome = "Junior";

            //PLACEHOLDERS
            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais.", nome, idade, saldo);
            //INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2} reais.");
            //CONCATENAÇÃO DE STRINGS
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            Console.WriteLine("AULA DE SAÍDA DE DADOS C#");

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde! :)");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("----------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            //-------------------------------------------------------------------------------------------------
            // AULA DE TIPOS DE DADOS EM C# - VARIAVEIS VALORES NUMÉRICOS
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("AULA DE TIPOS DE DADOS EM C# - VARIAVEIS VALORES NUMÉRICOS");
            Console.WriteLine("");

            int int1 = int.MinValue;
            int int2 = int.MaxValue;
            sbyte sByte3 = sbyte.MinValue;
            sbyte sByte4 = sbyte.MaxValue;
            decimal dec5 = decimal.MaxValue;

            Console.WriteLine(int1);
            Console.WriteLine(int2);
            Console.WriteLine(sByte3);
            Console.WriteLine(sByte4);
            Console.WriteLine(dec5);
            Console.WriteLine("");

            bool completo = false;
            genero = 'F';
            char letra = '\u004D';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5F;
            double n6 = 4.5;
            nome = "Junior Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5F;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            sbyte x = 100;

            Console.WriteLine(x);
        }
    }
}