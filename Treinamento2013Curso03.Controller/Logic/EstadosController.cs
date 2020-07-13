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

    public class EstadosController
    {
        private EstadosRepository repositorio;

        public EstadosController()
        {
            if (this.repositorio == null)
                this.repositorio = new EstadosRepository();
        }

        public void AdicionarEstado(UF estado)
        {
            try
            {
                this.repositorio.Incluir(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarEstado(UF estado)
        {
            try
            {
                this.repositorio.Alterar(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverEstado(UF estado)
        {
            try
            {
                this.repositorio.Excluir(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarEstadosXML()
        {
            try
            {
                List<UF> lista = this.repositorio.Obter().ToList<UF>();
                EstadosComposite composite = new EstadosComposite();
                return composite.ListarEstadosXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
