using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Contatos
{
    internal class Contatos
    {
        private List<Contato> agenda;

        public Contatos()
        {
            agenda = new List<Contato>();
        }

        public bool Adicionar(Contato c)
        {
            if (!agenda.Contains(c))
            {
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public Contato PesquisarPorEmail(string email)
        {
            return agenda.Find(contato => contato.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public bool Alterar(Contato c)
        {
            Contato contatoExistente = PesquisarPorEmail(c.Email);
            if (contatoExistente != null)
            {
                contatoExistente.Nome = c.Nome;
                contatoExistente.DtNasc = c.DtNasc;
                contatoExistente.Telefones = c.Telefones; 
                return true;
            }
            return false;
        }

        public bool Remover(Contato c)
        {
            return agenda.Remove(c);
        }

        public void Listar()
        {
            foreach (var contato in agenda)
            {
                Console.WriteLine(contato);
            }
        }
    }
}
