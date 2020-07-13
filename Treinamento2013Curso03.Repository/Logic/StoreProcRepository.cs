namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Data.Objects.DataClasses;

    using SGI.Framework.Architecture.Repository;

    public class StoreProcRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>
    {
        public IQueryable<PR_ListarFuncionarios_Result> ListarFuncionarios()
        {
            try
            {
                return this.Contexto.PR_ListarFuncionarios().AsQueryable<PR_ListarFuncionarios_Result>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<PR_ListarFuncionariosPorCargo_Result> ListarFuncionariosPorCargo(int idCargo)
        {
            try
            {
                return this.Contexto.PR_ListarFuncionariosPorCargo(idCargo).AsQueryable<PR_ListarFuncionariosPorCargo_Result>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<PR_ListarFuncionariosPorLotacao_Result> ListarFuncionariosPorLotacao(int idLotacao)
        {
            try
            {
                return this.Contexto.PR_ListarFuncionariosPorLotacao(idLotacao).AsQueryable<PR_ListarFuncionariosPorLotacao_Result>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<PR_ListarMunicipios_Result> ListarMunicipios()
        {
            try
            {
                return this.Contexto.PR_ListarMunicipios().AsQueryable<PR_ListarMunicipios_Result>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
