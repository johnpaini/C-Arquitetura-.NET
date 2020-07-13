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

    public class LotacoesRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>, IActionsConsult<Lotacao>, IActionsPersist<Lotacao>
    {
        public Lotacao Obter(object id)
        {
            try
            {
                int chave = Convert.ToInt32(id);
                Lotacao query = null;
                query = this.Contexto.Lotacaos.SingleOrDefault<Lotacao>(c => c.IDLotacao == chave);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Lotacao> Obter()
        {
            try
            {
                IQueryable<Lotacao> query = null;
                query = this.Contexto.Lotacaos;
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(Lotacao instancia)
        {
            try
            {
                this.Contexto.AddToLotacaos(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(Lotacao instancia)
        {
            try
            {
                Lotacao query = this.Obter(instancia.IDLotacao);
                this.Contexto.Lotacaos.ApplyCurrentValues(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Lotacao instancia)
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
