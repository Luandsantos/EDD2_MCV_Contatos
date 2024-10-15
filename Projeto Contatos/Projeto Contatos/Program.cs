using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Contatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contatos contatos = new Contatos();
            int opcao;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contatos");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: // Adicionar contato
                        Contato novoContato = CriarContato();
                        if (contatos.Adicionar(novoContato))
                        {
                            Console.WriteLine("Contato adicionado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Contato já existe.");
                        }
                        break;

                    case 2: // Pesquisar contato
                        Console.Write("Digite o e-mail do contato: ");
                        string emailPesquisar = Console.ReadLine();
                        Contato resultado = contatos.PesquisarPorEmail(emailPesquisar);
                        if (resultado != null)
                        {
                            Console.WriteLine("Contato encontrado:");
                            Console.WriteLine(resultado);
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;

                    case 3: // Alterar contato
                        Console.Write("Digite o e-mail do contato a ser alterado: ");
                        string emailAlterar = Console.ReadLine();
                        Contato contatoParaAlterar = contatos.PesquisarPorEmail(emailAlterar);

                        if (contatoParaAlterar != null)
                        {
                            Console.WriteLine("Contato encontrado:");
                            Console.WriteLine(contatoParaAlterar);
                            Console.WriteLine("Digite as novas informações (deixe em branco para não alterar):");
                            Console.Write("Nome: ");
                            string novoNome = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(novoNome))
                                contatoParaAlterar.Nome = novoNome;

                            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
                            string novaData = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(novaData))
                            {
                                var partesData = novaData.Split('/');
                                if (partesData.Length == 3 && int.TryParse(partesData[0], out int dia) &&
                                    int.TryParse(partesData[1], out int mes) && int.TryParse(partesData[2], out int ano))
                                {
                                    contatoParaAlterar.DtNasc.setData(dia, mes, ano);
                                }
                            }

                            // Atualizar telefones
                            Console.Write("Deseja alterar os telefones? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s")
                            {
                                Console.Write("Digite o tipo de telefone: ");
                                string tipo = Console.ReadLine();
                                Console.Write("Digite o número: ");
                                string numero = Console.ReadLine();
                                Console.Write("É o telefone principal? (s/n): ");
                                bool principal = Console.ReadLine().ToLower() == "s";

                                Telefone telefone = new Telefone(tipo, numero, principal);
                                contatoParaAlterar.AdicionarTelefone(telefone);
                            }

                            Console.WriteLine("Contato alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;

                    case 4: // Remover contato
                        Console.Write("Digite o e-mail do contato a ser removido: ");
                        string emailRemover = Console.ReadLine();
                        Contato contatoParaRemover = contatos.PesquisarPorEmail(emailRemover);
                        if (contatoParaRemover != null)
                        {
                            if (contatos.Remover(contatoParaRemover))
                            {
                                Console.WriteLine("Contato removido com sucesso!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;

                    case 5: // Listar contatos
                        Console.WriteLine("Lista de contatos:");
                        contatos.Listar();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static Contato CriarContato()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            Data dtNasc = new Data();
            Console.Write("Digite o dia de nascimento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês de nascimento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            dtNasc.setData(dia, mes, ano);

            Contato contato = new Contato(email, nome, dtNasc);

            Console.Write("Deseja adicionar um telefone? (s/n): ");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.Write("Digite o tipo de telefone: ");
                string tipo = Console.ReadLine();
                Console.Write("Digite o número: ");
                string numero = Console.ReadLine();
                Console.Write("É o telefone principal? (s/n): ");
                bool principal = Console.ReadLine().ToLower() == "s";

                Telefone telefone = new Telefone(tipo, numero, principal);
                contato.AdicionarTelefone(telefone);
            }

            return contato;
        }
    }
}