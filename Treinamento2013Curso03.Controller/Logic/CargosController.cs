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

    public class CargosController
    {
        private CargosRepository repositorio;

        public CargosController()
        {
            if (this.repositorio == null)
                this.repositorio = new CargosRepository();
        }

        public void AdicionarCargo(Cargo cargo)
        {
            try
            {
                this.repositorio.Incluir(cargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarCargo(Cargo cargo)
        {
            try
            {
                this.repositorio.Alterar(cargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverCargo(Cargo cargo)
        {
            try
            {
                this.repositorio.Excluir(cargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlDocument ListarCargosXML()
        {
            try
            {
                List<Cargo> lista = this.repositorio.Obter().ToList<Cargo>();
                CargosComposite composite = new CargosComposite();
                return composite.ListarCargosXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
