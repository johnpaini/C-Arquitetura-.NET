namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class EstadosComposite
    {
        public XmlDocument ListarEstadosXML(List<UF> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Estados");
                {
                    foreach (UF item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Estado");
                        {
                            XmlElement id = xdoc.CreateElement("ID");
                            id.InnerText = item.IDUF.ToString();
                            folha.AppendChild(id);

                            XmlElement descricao = xdoc.CreateElement("Descricao");
                            descricao.InnerText = item.DescricaoUF;
                            folha.AppendChild(descricao);

                            XmlElement sigla = xdoc.CreateElement("Sigla");
                            sigla.InnerText = item.Sigla;
                            folha.AppendChild(sigla);
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
