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

    public class EstadosRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>, IActionsConsult<UF>, IActionsPersist<UF>
    {
        public UF Obter(object id)
        {
            try
            {
                int chave = Convert.ToInt32(id);
                UF query = null;
                query = this.Contexto.UFs.SingleOrDefault<UF>(c => c.IDUF == chave);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<UF> Obter()
        {
            try
            {
                IQueryable<UF> query = null;
                query = this.Contexto.UFs;
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(UF instancia)
        {
            try
            {
                this.Contexto.AddToUFs(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(UF instancia)
        {
            try
            {
                UF query = this.Obter(instancia.IDUF);
                this.Contexto.UFs.ApplyCurrentValues(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(UF instancia)
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
