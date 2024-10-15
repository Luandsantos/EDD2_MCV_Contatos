using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Contatos
{
    internal class Contato
    {
       public string Email { get; set; }
    public string Nome { get; set; }
    public Data DtNasc { get; set; }
    private List<Telefone> telefones;

    public List<Telefone> Telefones
    {
        get { return telefones; }
        set { telefones = value; }
    }
    public Contato(string email, string nome, Data dtNasc)
    {
        Email = email;
        Nome = nome;
        DtNasc = dtNasc;
        telefones = new List<Telefone>();
    }

    public int GetIdade()
    {
        int idade = DateTime.Now.Year - DtNasc.Ano;
        if (DateTime.Now.Month < DtNasc.Mes || (DateTime.Now.Month == DtNasc.Mes && DateTime.Now.Day < DtNasc.Dia))
            idade--;
        return idade;
    }

    public void AdicionarTelefone(Telefone t)
    {
        telefones.Add(t);
    }

    public string GetTelefonePrincipal()
    {
        foreach (var telefone in telefones)
        {
            if (telefone.Principal)
                return telefone.Numero;
        }
        return "Nenhum telefone principal cadastrado.";
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Email: {Email}, Data de Nascimento: {DtNasc}, Telefone Principal: {GetTelefonePrincipal()}";
    }

        public override bool Equals(object obj)
        {
            if (obj is Contato contato)
            {
                return Email == contato.Email;
            }
            return false;
        }

    }
}
