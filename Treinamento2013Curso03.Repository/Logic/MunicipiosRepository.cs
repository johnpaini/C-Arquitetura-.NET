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

    public class MunicipiosRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>, IActionsConsult<Municipio>, IActionsPersist<Municipio>
    {
        public Municipio Obter(object id)
        {
            try
            {
                int chave = Convert.ToInt32(id);
                Municipio query = null;
                query = this.Contexto.Municipios.SingleOrDefault<Municipio>(c => c.IDMunicipio == chave);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Municipio> Obter()
        {
            try
            {
                IQueryable<Municipio> query = null;
                query = this.Contexto.Municipios;
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(Municipio instancia)
        {
            try
            {
                this.Contexto.AddToMunicipios(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(Municipio instancia)
        {
            try
            {
                Municipio query = this.Obter(instancia.IDMunicipio);
                this.Contexto.Municipios.ApplyCurrentValues(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Municipio instancia)
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
