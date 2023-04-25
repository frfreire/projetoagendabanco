using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoAgenda
{
    public class Agenda : IAgenda
    {
        private List<Contato> contatos = new List<Contato>();
        private string connStr = "server=localhost;user=developer;database=unip;port=3306;password=123456;";

        public void AdicionarContato(Contato c)
        {
            
            MySqlConnection conn = new MySqlConnection(this.connStr);

            try
            {
                conn.Open();
                string sqlInsert = $"INSERT INTO unip.contato (nome, email, telefone) VALUES ('{c.GetNome()}', '{c.GetEmail()}', '{c.GetTelefone()}')";
                MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("Registro inserido com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir registro: {ex.Message}");
            }
        }

        public void EditarContato(Contato c)
        {
            MySqlConnection conn = new MySqlConnection(this.connStr);

            try
            {
                conn.Open();
                string sqlUpdate = $"UPDATE unip.contato SET nome='{c.GetNome()}', email='{c.GetEmail()}' , telefone='{c.GetTelefone()}' WHERE idcontato={c.GetIdContato()}";
                MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                cmdUpdate.ExecuteNonQuery();
                Console.WriteLine("Registro atualizado com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar registro: {ex.Message}");
            }
        }

        public void ListarContatos()
        {
            MySqlConnection conn = new MySqlConnection(this.connStr);

            try
            {
                conn.Open();
                string sqlSelect = "SELECT * FROM unip.contato";
                MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conn);
                MySqlDataReader reader = cmdSelect.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}, Nome: {reader.GetString(1)}, EMail: {reader.GetString(2)}, Telefone: {reader.GetString(3)}");
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao selecionar registros: {ex.Message}");
            }

        }

        public void RemoverContato(int idContato)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sqlDelete = $"DELETE FROM unip.contato WHERE idcontato={idContato}";
                MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, conn);
                cmdDelete.ExecuteNonQuery();
                Console.WriteLine("Registro excluído com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir registro: {ex.Message}");
            }

        }
    }
}
