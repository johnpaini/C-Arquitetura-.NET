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

    public class CargosRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>, IActionsConsult<Cargo>, IActionsPersist<Cargo>
    {
        public Cargo Obter(object id)
        {
            try
            {
                int chave = Convert.ToInt32(id);
                Cargo query = null;
                query = this.Contexto.Cargoes.SingleOrDefault<Cargo>(c => c.IDCargo == chave);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Cargo> Obter()
        {
            try
            {
                IQueryable<Cargo> query = null;
                query = this.Contexto.Cargoes;
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(Cargo instancia)
        {
            try
            {
                this.Contexto.AddToCargoes(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(Cargo instancia)
        {
            try
            {
                Cargo query = this.Obter(instancia.IDCargo);
                this.Contexto.Cargoes.ApplyCurrentValues(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Cargo instancia)
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
