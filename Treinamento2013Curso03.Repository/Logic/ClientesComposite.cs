namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class ClientesComposite
    {
        public XmlDocument ListarXML(List<Cliente> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Clientes");
                {
                    foreach (Cliente item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Cliente");
                        {
                            XmlAttribute id = xdoc.CreateAttribute("ID");
                            id.InnerText = item.ID.ToString();
                            folha.Attributes.Append(id);

                            XmlElement nome = xdoc.CreateElement("Nome");
                            nome.InnerText = item.Nome;
                            folha.AppendChild(nome);

                            XmlElement sobrenome = xdoc.CreateElement("Sobrenome");
                            sobrenome.InnerText = item.Sobrenome;
                            folha.AppendChild(sobrenome);

                            XmlElement cargo = xdoc.CreateElement("Cargo");
                            cargo.InnerText = item.Cargo;
                            folha.AppendChild(cargo);

                            XmlElement lotacao = xdoc.CreateElement("Lotacao");
                            lotacao.InnerText = item.Lotacao;
                            folha.AppendChild(lotacao);

                            XmlElement telefone = xdoc.CreateElement("Telefone");
                            telefone.InnerText = item.Telefone;
                            folha.AppendChild(telefone);
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
