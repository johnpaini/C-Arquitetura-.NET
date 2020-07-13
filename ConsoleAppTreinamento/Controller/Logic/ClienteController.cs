namespace ConsoleAppTreinamento.Controller.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Repository.Logic;
    using ModelData.Logic;

    public class ClienteController
    {
        private ClienteRepository repositorio;

        public ClienteController()
        {
            if (this.repositorio == null)
                this.repositorio = new ClienteRepository();
        }

        public void Inserir()
        {
            Console.Clear();

            Console.WriteLine("Inserir novo Cliente");

            Cliente cliente = new Cliente();

            Console.Write("ID: ");
            string id = Console.ReadLine();
            cliente.Id = Convert.ToInt32(id);

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            cliente.SobreNome = Console.ReadLine();

            Console.Write("Cargo: ");
            cliente.Cargo = Console.ReadLine();

            Console.Write("Lotacao: ");
            cliente.Lotacao = Console.ReadLine();

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            this.repositorio.Incluir(cliente);
        }

        public void Atualizar()
        { }

        public void Remover()
        { }

        public void Listar()
        {
            Console.Clear();

            Console.WriteLine("Listar Cliente");

            Console.Write("Informe um ID: ");
            string temp = Console.ReadLine();
            int id = Convert.ToInt32(temp);

            Cliente cliente = this.repositorio.Obter(id);
            this.Imprimir(cliente);
        }

        private void Imprimir(Cliente cliente)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ID: {0}", cliente.Id);
            Console.WriteLine("Nome: {0}", cliente.Nome);
            Console.WriteLine("Sobrenome: {0}", cliente.SobreNome);
            Console.WriteLine("Cargo: {0}", cliente.Cargo);
            Console.WriteLine("Lotacao: {0}", cliente.Lotacao);
            Console.WriteLine("Telefone: {0}", cliente.Telefone);
            Console.WriteLine("------------------------------------------");
        }

        public void ListarTodos()
        {
            Console.Clear();

            Console.WriteLine("Listagem de Clientes");

            foreach (Cliente item in this.repositorio.ListaDeClientes)
            {
                this.Imprimir(item);
            }
        }
    }
}
