namespace Teste001
{
    internal class ContaBancaria
    {
        private int _numeroDaConta { get; set; }
        private string _nomeTitular { get; set; }
        public char[] AbrirComSaldo { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numerodaconta, string nometitular, double saldo)
        {
            _numeroDaConta = numerodaconta;
            _nomeTitular = nometitular;
            Saldo = saldo;

        }
        public int NumeroDaconta
        {
            get => _numeroDaConta;
            set
            {
                _numeroDaConta = value;
            }
        }

        public string NomeTitular
        {
            get => _nomeTitular;
            set
            {
                _nomeTitular = value;
            }
        }

        public double AbrirSaldo(char abrir)
        {

            if (abrir == 's')
            {
                IniciarContaDeposito();
            }
            else
            {
                Console.WriteLine("Seu saldo é de 0,00");
                IniciarContaSemSaldo();
            }

            return Saldo;
        }

        public double IniciarContaDeposito()
        {
            Console.Write("Digite quanto de saldo será adicionado: ");
            Saldo = double.Parse(Console.ReadLine());
            Console.WriteLine(Saldo.ToString("F2"));

            return Saldo;
        }

        public double IniciarContaSemSaldo()
        {
            Saldo = 0;
            return Saldo;
        }

        public void DepositarSaldo(double saldo)
        {
            Saldo += saldo;
        }

        public void SacarSaldo(double saldo)
        {
            Saldo -= saldo;
        }

    }
}