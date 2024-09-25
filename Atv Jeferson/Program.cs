using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Jeferson
{
    internal class Program
    {
        static Pessoa[] pacientes = new Pessoa[10];
        static void Main(string[] args)
        {
            pacientes[0] = new Pessoa
            {
                nome = "Maria Silva",
                telefone = "1234-5678",
                data_de_nascimento = "20/05/1955",
                Idade = 69,
                prioridade = true,
                doença = "Hipertensão",
                deficiencia = false
            };
            pacientes[1] = new Pessoa
            {
                nome = "João Santos",
                telefone = "9876-5432",
                data_de_nascimento = "15/02/1940",
                Idade = 84,
                prioridade = true,
                doença = "Diabetes",
                deficiencia = false
            };
            pacientes[2] = new Pessoa
            {
                nome = "Ana Pereira",
                telefone = "4567-8910",
                data_de_nascimento = "30/07/1985",
                Idade = 39,
                prioridade = false,
                doença = "Asma",
                deficiencia = true
            };
            pacientes[3] = new Pessoa
            {
                nome = "Carlos Oliveira",
                telefone = "2345-6789",
                data_de_nascimento = "10/10/2000",
                Idade = 23,
                prioridade = false,
                doença = "Nenhuma",
                deficiencia = true
            };
            pacientes[4] = new Pessoa
            {
                nome = "Lucia Costa",
                telefone = "5432-1098",
                data_de_nascimento = "25/03/1970",
                Idade = 54,
                prioridade = false,
                doença = "Câncer",
                deficiencia = true
            };
            pacientes[5] = new Pessoa
            {
                nome = "Pedro Almeida",
                telefone = "6789-1234",
                data_de_nascimento = "12/12/1965",
                Idade = 58,
                prioridade = false,
                doença = "Nenhuma",
                deficiencia = true
            };
            pacientes[6] = new Pessoa
            {
                nome = "Fernanda Lima",
                telefone = "3210-9876",
                data_de_nascimento = "16/08/1990",
                Idade = 34,
                prioridade = false,
                doença = "Alergia",
                deficiencia = false
            };
            pacientes[7] = new Pessoa
            {
                nome = "Ricardo Mendes",
                telefone = "0987-6543",
                data_de_nascimento = "11/11/1980",
                Idade = 43,
                prioridade = false,
                doença = "Gripe",
                deficiencia = false
            };
            pacientes[8] = new Pessoa
            {
                nome = "Tatiane Rocha",
                telefone = "3456-7890",
                data_de_nascimento = "21/04/1995",
                Idade = 29,
                prioridade = false,
                doença = "Nenhuma",
                deficiencia = false
            };
            pacientes[9] = new Pessoa
            {
                nome = "Roberto Gomes",
                telefone = "1230-4567",
                data_de_nascimento = "30/09/2003",
                Idade = 20,
                prioridade = false,
                doença = "Nenhuma",
                deficiencia = false
            };
            int max = 10;
            bool[] sair = new bool[max];
            sair[0] = false;
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Medico medico = new Medico();
            medico.nome = nome;
            do
            {
                Console.WriteLine($"Ola Doutor {medico.nome}");
                Console.WriteLine("O que deseja fazer?\n1)Ve lista\n2)Sair(digite q)");
                string[] opc = new string[max];
                opc[0] = Console.ReadLine();
                switch (opc[0])
                {
                    case "1":
                        medico.OrganizarPrioridade(pacientes);
                        foreach (var paciente in pacientes)
                        {
                            Console.WriteLine($"Nome: {paciente.nome}, Idade: {paciente.Idade}, Prioridade: {paciente.prioridade}, Doença: {paciente.doença}, Deficiência: {paciente.deficiencia}");
                        }
                        break;
                    case "q":
                        Console.WriteLine("Saindo");
                        Console.ReadKey();
                        sair[0] = true;
                        break;
                    default:
                        Console.WriteLine("opcao invalida");
                        break;
                }
            } while (sair[0] == false);
        }
    }
}
