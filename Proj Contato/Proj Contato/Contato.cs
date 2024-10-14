using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Contato
{
    internal class Contato
    {

        /*
        Contato                               
        |---------------------------------------|
        | - email: string                       |
        | - nome: string                        |
        | - dtNasc: Data                        |
        | - telefones: List<Telefone>           |
        |---------------------------------------|
        | + getIdade(): int                     |
        | + adicionarTelefone(Telefone t): void |
        | + getTelefonePrincipal(): string      |
        | + ToString(): String (override)       |
        |   -> retornando uma string com        |
        |      todos os dados do contato        |
        |      (considerando o telefone         |
        |      principal)                       |
        | + Equals(object obj): bool (override) |
         * 
   
         */

        private string email;
        private string nome;
        private Data dtNasc;
        private List<Telefone> telefones;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Data DtNasc
        {
            get { return dtNasc; }
            set { dtNasc = value; }
        }

        public List<Telefone> Telefones
        {
            get { return telefones; }
            set { telefones = value; }
        }

        public Contato(string email, string nome)
        {
            this.email = email;
            this.nome = nome;
        }

        public Contato(string email, string nome, Data dtNasc, List<Telefone> telefones)
        {
            this.email = email;
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.telefones = telefones;
        }

        public int getIdade()
        {
            int idade = DateTime.Now.Year - dtNasc.Ano;
            return idade;
        }

        public void adicionarTelefone(Telefone t)
        {
            telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            foreach (Telefone t in telefones)
            {
                if (t.Principal == true)
                {
                    return t.Numero;
                }
            }
            return "";
        }

        public override string ToString()
        {
            string dados = "Nome: " + Nome
                    + " Data de Nascimento: " + DtNasc
                    + " Idade: " + getIdade().ToString()
                    + " E-mail: " + Email
                    + " Telefone Principal" + Telefones.ToString();
            return dados;
        }

        public override bool Equals(object obj)
        {
            return this.nome == ((Contato)obj).nome;

        }
    }
}
