namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class MunicipiosComposite
    {
        public XmlDocument ListarMunicipiosXML(List<Municipio> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Municipios");
                {
                    foreach (Municipio item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Municipio");
                        {
                            XmlElement id = xdoc.CreateElement("ID");
                            id.InnerText = item.IDMunicipio.ToString();
                            folha.AppendChild(id);

                            XmlElement descricao = xdoc.CreateElement("Descricao");
                            descricao.InnerText = item.DescricaoMunicipio;
                            folha.AppendChild(descricao);

                            XmlElement uf = xdoc.CreateElement("UF");
                            uf.InnerText = item.IDUF.ToString();
                            folha.AppendChild(uf);
                        }
                        raiz.AppendChild(folha);
                    }
                }
                xdoc.AppendChild(raiz);
                return xdoc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
