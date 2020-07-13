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

    public class LotacoesController
    {
        private LotacoesRepository repositorio;

        public LotacoesController()
        {
            if (this.repositorio == null)
                this.repositorio = new LotacoesRepository();
        }

        public void AdicionarLotacao(Lotacao lotacao)
        {
            try
            {
                this.repositorio.Incluir(lotacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarLotacao(Lotacao lotacao)
        {
            try
            {
                this.repositorio.Alterar(lotacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverLotacao(Lotacao lotacao)
        {
            try
            {
                this.repositorio.Excluir(lotacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Lotacao ListarLotacoes(object id)
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

        public IQueryable<Lotacao> ListarLotacoes()
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

        public XmlDocument ListarLotacoesXML()
        {
            try
            {
                List<Lotacao> lista = this.repositorio.Obter().ToList<Lotacao>();
                LotacoesComposite composite = new LotacoesComposite();
                return composite.ListarLotacoesXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
