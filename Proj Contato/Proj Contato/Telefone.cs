using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Contato
{
    internal class Telefone
    {
        private string tipo;
        private string numero;
        private bool principal;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Numero { 
            get { return numero; } 
            set {  numero = value; } 
        }

        public bool Principal
        {
            get { return principal; }
            set { principal = value; }
        }

        public Telefone()
        {
            this.tipo = "";
            this.numero = "";
            this.principal = false;
        }

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }
    }
}
