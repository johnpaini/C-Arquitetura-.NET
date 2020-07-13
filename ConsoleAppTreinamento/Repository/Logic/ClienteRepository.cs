namespace ConsoleAppTreinamento.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ModelData.Logic;

    public class ClienteRepository
    {
        private List<Cliente> listaDeClientes;
        public List<Cliente> ListaDeClientes
        {
            get { return this.listaDeClientes; }
        }

        public ClienteRepository()
        {
            if (this.listaDeClientes == null)
                this.listaDeClientes = new List<Cliente>();
        }

        public void Incluir(Cliente cliente)
        {
            //this.listaDeClientes.Insert(this.listaDeClientes.Count, cliente);
            this.listaDeClientes.Add(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            Cliente cli = this.Obter(cliente.Id);
            this.Excluir(cli);
            this.Incluir(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            this.listaDeClientes.Remove(cliente);
        }

        public Cliente Obter(int id)
        {
            Cliente retorno = null;

            //foreach (Cliente item in this.listaDeClientes)
            //{
            //    if (item.Id == id)
            //    {
            //        retorno = item;
            //        break;
            //    }
            //}

            //retorno = this.listaDeClientes.Find(c => c.Id == id);

            retorno = this.listaDeClientes.SingleOrDefault<Cliente>(c => c.Id == id);

            return retorno;
        }

        public List<Cliente> Obter()
        {
            return this.listaDeClientes;
        }
    }
}
