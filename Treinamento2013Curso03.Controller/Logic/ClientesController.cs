namespace Treinamento2013Curso03.Controller.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;
    using Treinamento2013Curso03.Repository.Logic;

    using System.Data.Objects.DataClasses;
    using System.Xml;

    public class ClientesController
    {
        private ClientesRepository repositorio;

        public ClientesController()
        {
            if (this.repositorio == null)
                this.repositorio = new ClientesRepository();
        }

        public void Adicionar(Cliente cliente)
        {
            try
            {
                this.repositorio.Incluir(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualizar(Cliente cliente)
        {
            try
            {
                this.repositorio.Alterar(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(Cliente cliente)
        {
            try
            {
                this.repositorio.Excluir(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente Listar(object id)
        {
            try
            {
                return this.repositorio.Obter(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Cliente> Listar()
        {
            try
            {
                return this.repositorio.Obter();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarTodosXML()
        {
            try
            {
                List<Cliente> lista = this.repositorio.Obter().ToList<Cliente>();
                ClientesComposite composite = new ClientesComposite();
                return composite.ListarXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
