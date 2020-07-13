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

    public class FuncionariosController
    {
        private FuncionariosRepository repositorio;

        public FuncionariosController()
        {
            if (this.repositorio == null)
                this.repositorio = new FuncionariosRepository();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                this.repositorio.Incluir(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            try
            {
                this.repositorio.Alterar(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            try
            {
                this.repositorio.Excluir(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario ListarFuncionarios(object id)
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

        public IQueryable<Funcionario> ListarFuncionario()
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

        public XmlDocument ListarFuncionariosXML()
        {
            try
            {
                List<Funcionario> lista = this.repositorio.Obter().ToList<Funcionario>();
                FuncionariosComposite composite = new FuncionariosComposite();
                return composite.ListarFuncionariosXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
