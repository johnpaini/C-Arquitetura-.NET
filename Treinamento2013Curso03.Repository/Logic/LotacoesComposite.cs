namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class LotacoesComposite
    {
        public XmlDocument ListarLotacoesXML(List<Lotacao> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Lotacoes");
                {
                    foreach (Lotacao item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Lotacao");
                        {
                            XmlElement id = xdoc.CreateElement("ID");
                            id.InnerText = item.IDLotacao.ToString();
                            folha.AppendChild(id);

                            XmlElement descricao = xdoc.CreateElement("Descricao");
                            descricao.InnerText = item.DescricaoLotacao;
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
