using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Jeferson
{
    internal class Pessoa
    {
        public string nome;
        public string telefone;
        public string data_de_nascimento;
        public int Idade;
        public bool prioridade;
        public string doença;
        public bool deficiencia;
        private bool verificarBi(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }
        private void pegarNome()
        {
            int val;
            do
            {
                Console.WriteLine("digite seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine($"Nome: {nome}\nNome esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro1");
                    Console.WriteLine($"Nome: {nome}\nNome esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }
        private void pegarData()
        {
            DateTime dataNascimento;
            bool dataValida;

            do
            {
                Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa):");
                string entrada = Console.ReadLine();
                dataValida = DateTime.TryParseExact(entrada, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out dataNascimento);
                if (dataValida && dataNascimento <= DateTime.Now)
                {
                    Console.WriteLine($"Data de nascimento: {dataNascimento:dd/MM/yyyy}");
                    Console.WriteLine("Data de nascimento certa?\n1) Sim\n2) Não");
                    int escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        data_de_nascimento = dataNascimento.ToString("dd/MM/yyyy");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Data inválida ou está no futuro. Tente novamente.");
                }

            } while (true);
        }
        private void pegarTelefone()
        {
            int val;
            do
            {
                Console.WriteLine("Digite seu Telefone com DDD:");
                telefone = Console.ReadLine();
                while (telefone.Length != 11 || !telefone.All(char.IsDigit))
                {
                    Console.WriteLine("Telefone inválido!");
                    Console.WriteLine("Digite seu Telefone:");
                    telefone = Console.ReadLine();
                }
                telefone = telefone.Trim();
                telefone = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
                Console.WriteLine(telefone);
                Console.WriteLine($"Telefone: {telefone}\nTelefone esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine($"Telefone: {telefone}\nTelefone esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }
        private bool Prioridade()
        {
            DateTime dataNascimento = DateTime.ParseExact(data_de_nascimento, "dd/MM/yyyy", null);
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataAtual < dataNascimento.AddYears(idade))
            {
                idade--;
            }
            Idade = idade;
            if (deficiencia == true)
            {
                prioridade = true;
            }
            prioridade = idade > 60;
            return prioridade;
        }
        protected void digitarDoença()
        {
            int val;
            do
            {
                Console.WriteLine("digite a doença do paciente:");
                doença = Console.ReadLine();
                Console.WriteLine($"Doença: {doença}\nDoença esta correto?\n1)Sim\n2)Não");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    val = 1;
                }
                else if (val == 2)
                {
                    val = 0;
                }
                else
                {
                    Console.WriteLine("Erro1");
                    Console.WriteLine($"Doença: {doença}\nDoença esta correto?\n1)Sim\n2)Não");
                    val = int.Parse(Console.ReadLine());
                }
            } while (val == 0);
        }
        public virtual void Cadastrar()
        {
            Console.WriteLine("Cadastro\n");
            pegarNome();
            pegarData();
            Prioridade();
            digitarDoença();
            Console.WriteLine("Paciente possui alguma preferencia\n1)sim\n2)nao");
            int op=int.Parse(Console.ReadLine());
            if (op == 1)
            {
                deficiencia = true;
            }
        }
    }
}
