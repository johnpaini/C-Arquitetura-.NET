namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Data.Objects.DataClasses;

    using SGI.Framework.Architecture.Repository;

    using SGI.Framework.Architecture.Repository.Actions;

    public class ClientesRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>,
        IActionsConsult<Cliente>,
        IActionsPersist<Cliente>
    {
        public Cliente Obter(object id)
        {
            try
            {
                int chave = Convert.ToInt32(id);
                Cliente query = null;
                query = this.Contexto.Clientes.SingleOrDefault<Cliente>(c => c.ID == chave);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Cliente> Obter()
        {
            try
            {
                IQueryable<Cliente> query = null;
                query = this.Contexto.Clientes;
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(Cliente instancia)
        {
            try
            {
                this.Contexto.AddToClientes(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(Cliente instancia)
        {
            try
            {
                Cliente query = this.Obter(instancia.ID);
                this.Contexto.Clientes.ApplyCurrentValues(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Cliente instancia)
        {
            try
            {
                this.Contexto.DeleteObject(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
