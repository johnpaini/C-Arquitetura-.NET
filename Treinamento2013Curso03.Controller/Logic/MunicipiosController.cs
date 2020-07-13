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

    public class MunicipiosController
    {
        private MunicipiosRepository repositorio;

        public MunicipiosController()
        {
            if (this.repositorio == null)
                this.repositorio = new MunicipiosRepository();
        }

        public void AdicionarMunicipio(Municipio municipio)
        {
            try
            {
                this.repositorio.Incluir(municipio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarMunicipio(Municipio municipio)
        {
            try
            {
                this.repositorio.Alterar(municipio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverMunicipio(Municipio municipio)
        {
            try
            {
                this.repositorio.Excluir(municipio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Municipio ListarMunicipios(object id)
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

        public IQueryable<Municipio> ListarMunicipios()
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

        public XmlDocument ListarMunicipiosXML()
        {
            try
            {
                List<Municipio> lista = this.repositorio.Obter().ToList<Municipio>();
                MunicipiosComposite composite = new MunicipiosComposite();
                return composite.ListarMunicipiosXML(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
