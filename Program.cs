namespace ProjetoAgenda
{


    public class Program
    {

        public static void Main(string[] args)
        {
            Agenda agenda = new Agenda();



            while (true) {

                Console.WriteLine("\n----- MENU -----\n");
                Console.WriteLine("1 - Inserir novo registro");
                Console.WriteLine("2 - Selecionar todos os registros");
                Console.WriteLine("3 - Atualizar registro existente");
                Console.WriteLine("4 - Excluir registro existente");
                Console.WriteLine("5 - Sair");
                Console.Write("\nDigite a opção desejada: ");

                string op = Console.ReadLine();
                Console.WriteLine();

                switch (op) {

                    case "1":
                        Console.Write("\nDigite o nome do contato: ");
                        string nome = Console.ReadLine();

                        Console.Write("\nDigite o email do contato: ");
                        string email = Console.ReadLine();

                        Console.Write("\nDigite o telefone do contato: ");
                        string telefone  = Console.ReadLine();

                        Contato c = new Contato();
                        c.SetNome(nome);
                        c.SetEmail(email);
                        c.SetTelefone(telefone);

                        agenda.AdicionarContato(c);

                        break;
                    case "2":

                        agenda.ListarContatos();
                        break;

                    case "3":

                        Console.Write("\nDigite o ID do registro que deseja atualizar: ");
                        int idAtualizaContato = int.Parse(Console.ReadLine());

                        Console.Write("Digite o novo nome do contato: ");
                        string novoNome = Console.ReadLine();

                        Console.Write("Digite o novo email do contato: ");
                        string novoEmail = Console.ReadLine();

                        Console.Write("Digite o novo telefone do contato: ");
                        string novoTelefone = Console.ReadLine();

                        Contato c2 = new Contato();
                        c2.SetIdContato(idAtualizaContato);
                        c2.SetNome(novoNome);
                        c2.SetEmail(novoEmail);
                        c2.SetTelefone(novoTelefone);

                        agenda.EditarContato(c2);

                        break;
                    case "4":

                        Console.Write("\nDigite o ID do registro que deseja excluir: ");

                        int idRemoveContato = int.Parse(Console.ReadLine());

                        agenda.RemoverContato(idRemoveContato);

                        break;
                    case "5":
                        return;
                }

            }
            

        }
    
    }

}