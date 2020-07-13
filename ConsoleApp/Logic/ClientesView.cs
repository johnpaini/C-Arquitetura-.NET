namespace ConsoleApp.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;
    using Treinamento2013Curso03.Repository.Logic;
    using Treinamento2013Curso03.Controller.Logic;

    using System.Data.Objects.DataClasses;
    using System.Xml;

    public class ClientesView
    {
        private ClientesController controle;
        public ClientesView()
        {
            if (this.controle == null)
                this.controle = new ClientesController();
        }

        public void Inserir()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Inserir novo Cliente");

                Cliente cliente = new Cliente();

                Console.Write("ID: ");
                string id = Console.ReadLine();
                cliente.ID = Convert.ToInt32(id);

                Console.Write("Nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Sobrenome: ");
                cliente.Sobrenome = Console.ReadLine();

                Console.Write("Cargo: ");
                cliente.Cargo = Console.ReadLine();

                Console.Write("Lotacao: ");
                cliente.Lotacao = Console.ReadLine();

                Console.Write("Telefone: ");
                cliente.Telefone = Console.ReadLine();

                this.controle.Adicionar(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Remover Cliente");
                Console.Write("Informe um ID: ");
                string temp = Console.ReadLine();
                int id = Convert.ToInt32(temp);
                Cliente cliente = this.controle.Listar(id);
                this.controle.Remover(cliente);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void Listar()
        {
            Console.Clear();

            Console.WriteLine("Listar Cliente");

            Console.Write("Informe um ID: ");
            string temp = Console.ReadLine();
            int id = Convert.ToInt32(temp);

            Cliente cliente = this.controle.Listar(id);
            this.Imprimir(cliente);
        }

        private void Imprimir(Cliente cliente)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ID: {0}", cliente.ID);
            Console.WriteLine("Nome: {0}", cliente.Nome);
            Console.WriteLine("Sobrenome: {0}", cliente.Sobrenome);
            Console.WriteLine("Cargo: {0}", cliente.Cargo);
            Console.WriteLine("Lotacao: {0}", cliente.Lotacao);
            Console.WriteLine("Telefone: {0}", cliente.Telefone);
            Console.WriteLine("------------------------------------------");
        }

        public void ListarTodos()
        {
            Console.Clear();

            Console.WriteLine("Listagem de Clientes");

            List<Cliente> lista = this.controle.Listar().ToList<Cliente>();

            foreach (Cliente item in lista)
            {
                this.Imprimir(item);
            }
        }

        public void ImprimirXML()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Impressão do XML");
                Console.WriteLine("Todos os registros");
                Console.WriteLine("");

                XmlDocument xdoc = this.controle.ListarTodosXML();
                Console.WriteLine(xdoc.OuterXml);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
