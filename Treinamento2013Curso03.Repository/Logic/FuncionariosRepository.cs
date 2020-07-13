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

    public class FuncionariosRepository : BaseRepositoryEntityFramework<Curso2013Turma03Entities>, IActionsConsult<Funcionario>, IActionsPersist<Funcionario>
    {
        public Funcionario Obter(object id)
        {
            try
            {
                int chave = Convert.ToInt32(id);
                Funcionario query = null;
                query = this.Contexto.Funcionarios.SingleOrDefault<Funcionario>(c => c.IDFuncionario == chave);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Funcionario> Obter()
        {
            try
            {
                IQueryable<Funcionario> query = null;
                query = this.Contexto.Funcionarios;
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(Funcionario instancia)
        {
            try
            {
                this.Contexto.AddToFuncionarios(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(Funcionario instancia)
        {
            try
            {
                Funcionario query = this.Obter(instancia.IDFuncionario);
                this.Contexto.Funcionarios.ApplyCurrentValues(instancia);
                this.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Funcionario instancia)
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
