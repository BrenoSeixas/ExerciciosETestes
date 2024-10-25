using System;
using System.Net.Http.Headers;
using System.Threading.Channels;
using Teste001;

namespace Curso
{
    class Program
    {

        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();

            Console.Write("Entre com número da conta: ");
            contaBancaria.NumeroDaconta = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");

            Console.Write("Entre com o número titular da conta: ");
            contaBancaria.NomeTitular = Console.ReadLine();
            Console.WriteLine("------------------");

            Console.Write("Haverá deposito inicial? (s/n): ");
            char saldoInicial = char.Parse(Console.ReadLine());
            contaBancaria.AbrirSaldo(saldoInicial);


            Console.WriteLine($"Dados da conta: Conta {contaBancaria.NumeroDaconta} o titular é {contaBancaria.NomeTitular} e o saldo é {contaBancaria.Saldo} ");
            Console.WriteLine("------------------");

            Console.Write("De quanto será o deposito?: ");
            double deposito = double.Parse(Console.ReadLine());
            contaBancaria.DepositarSaldo(deposito);
            Console.WriteLine("------------------");

            Console.WriteLine($"Dados da conta: Conta {contaBancaria.NumeroDaconta} o titular é {contaBancaria.NomeTitular} e o saldo é {contaBancaria.Saldo} ");

            Console.Write("De quanto será o saque?: ");
            double saque = double.Parse(Console.ReadLine());
            contaBancaria.SacarSaldo(saque);
            Console.WriteLine("------------------");

            Console.WriteLine($"Dados da conta: Conta {contaBancaria.NumeroDaconta} o titular é {contaBancaria.NomeTitular} e o saldo é {contaBancaria.Saldo} ");
        }
    }
}