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

    public class StoreProcController
    {
        private StoreProcRepository repositorio;

        public StoreProcController()
        {
            if (this.repositorio == null)
                this.repositorio = new StoreProcRepository();
        }

        public IQueryable<PR_ListarFuncionarios_Result> ListarFuncionarios()
        {
            try
            {
                return this.repositorio.ListarFuncionarios();
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
                return this.repositorio.ListarFuncionariosPorCargo(idCargo);
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
                return this.repositorio.ListarFuncionariosPorLotacao(idLotacao);
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
                return this.repositorio.ListarMunicipios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarTodosFuncionariosXML()
        {
            try
            {
                List<PR_ListarFuncionarios_Result> lista = this.repositorio.ListarFuncionarios().ToList<PR_ListarFuncionarios_Result>();
                StoreProcComposite composite = new StoreProcComposite();
                return composite.ListarFuncionariosXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarTodosFuncionariosPorCargoXML(int idCargo)
        {
            try
            {
                List<PR_ListarFuncionariosPorCargo_Result> lista = this.repositorio.ListarFuncionariosPorCargo(idCargo).ToList<PR_ListarFuncionariosPorCargo_Result>();
                StoreProcComposite composite = new StoreProcComposite();
                return composite.ListarFuncionariosPorCargoXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarTodosFuncionariosPorLotacaoXML(int idLotacao)
        {
            try
            {
                List<PR_ListarFuncionariosPorLotacao_Result> lista = this.repositorio.ListarFuncionariosPorLotacao(idLotacao).ToList<PR_ListarFuncionariosPorLotacao_Result>();
                StoreProcComposite composite = new StoreProcComposite();
                return composite.ListarFuncionariosPorLotacaoXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarTodosMunicipiosXML()
        {
            try
            {
                List<PR_ListarMunicipios_Result> lista = this.repositorio.ListarMunicipios().ToList<PR_ListarMunicipios_Result>();
                StoreProcComposite composite = new StoreProcComposite();
                return composite.ListarMunicipiosXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
