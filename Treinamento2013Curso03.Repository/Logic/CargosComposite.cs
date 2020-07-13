namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class CargosComposite
    {
        public XmlDocument ListarCargosXML(List<Cargo> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Cargos");
                {
                    foreach (Cargo item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Cargo");
                        {
                            XmlElement id = xdoc.CreateElement("ID");
                            id.InnerText = item.IDCargo.ToString();
                            folha.AppendChild(id);

                            XmlElement descricao = xdoc.CreateElement("Descricao");
                            descricao.InnerText = item.DescricaoCargo;
                            folha.AppendChild(descricao);
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
