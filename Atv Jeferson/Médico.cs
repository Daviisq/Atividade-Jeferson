using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Jeferson
{
    internal class Medico : Pessoa
    {
        public void verLista(Pessoa[] lista)
        {
            OrganizarPrioridade(lista);
            int n=lista.Length; 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Paciente numero {i + 1} : {lista[i].nome}");
                Console.ReadKey();
            }
        }
        public void OrganizarPrioridade(Pessoa[] lista)
        {
            for (int i = 0; i < lista.Length - 1; i++)
            {
                for (int j = 0; j < lista.Length - 1 - i; j++)
                {
                    if (lista[j].prioridade == false && lista[j + 1].prioridade == true)
                    {
                        Pessoa temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
        public void Cadastrar(Pessoa[] paciente)
        {
            Pessoa novoPaciente = new Pessoa();
            novoPaciente.Cadastrar();
        }
    }
}
