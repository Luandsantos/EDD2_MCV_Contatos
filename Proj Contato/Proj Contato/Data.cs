using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Contato
{
    internal class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia
        {
            get => dia;
            set => dia = value;
        }

        public int Mes
        {
            get => mes;
            set => mes = value;
        }

        public int Ano
        {
            get => ano;
            set => ano = value;
        }

        public Data()
        {
            this.dia = 0;
            this.mes = 0;
            this.ano = 0;
        }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString() {
            return Dia + "/" + Mes + "/" + Ano;
        }


    }
}