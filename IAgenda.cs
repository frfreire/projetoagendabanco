using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    public interface IAgenda
    {
        void AdicionarContato(Contato c);
        void RemoverContato(int idContato);
        void ListarContatos();
        void EditarContato(Contato c);
    }
}
