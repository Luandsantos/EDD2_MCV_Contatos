using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Contato
{
    internal class Contatos
    {
        private readonly List<Contato> agenda;

        /*
         + adicionar(Contato c): bool          |
| + pesquisar(Contato c): Contato       |
| + alterar(Contato c): bool            |
| + remover(Contato c): bool
         */

        public List<Contato> Agenda
        {
            get { return agenda; }
        }

        public bool adicionar(Contato c)
        {
            return true;
        }

        public Contato pesquisar(Contato c)
        {
            Contato contato_pesquisado = new Contato("@email", "telefone");
            return contato_pesquisado;
        }

        public bool alterar(Contato c)
        {
            return false;
        }

        public bool remover(Contato c)
        {
            return true;
        }

    }
}
