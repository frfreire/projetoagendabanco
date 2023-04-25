using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    public class Contato
    {
        private int? idContato;
        private string? nome;
        private string? email;
        private string? telefone;

        public int GetIdContato()
        {
            return (int)idContato;
        }
        public string GetNome() 
        {
            return nome;
        }

        public string GetEmail() 
        { 
            return email; 
        }
        public string GetTelefone() 
        {
            return telefone;
        }

        public void SetIdContato(int idContato)
        {
            this.idContato = idContato;
        }
        public void SetNome(string nome) 
        { 
            this.nome = nome; 
        }

        public void SetEmail(string email) 
        { 
            this.email = email;
        }

        public void SetTelefone(string telefone)
        { 
            this.telefone = telefone;
        }
    }
}
