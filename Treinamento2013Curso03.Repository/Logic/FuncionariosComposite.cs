namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class FuncionariosComposite
    {
        public XmlDocument ListarFuncionariosXML(List<Funcionario> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Funcionarios");
                {
                    foreach (Funcionario item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Funcionario");
                        {
                            XmlElement id = xdoc.CreateElement("ID");
                            id.InnerText = item.IDFuncionario.ToString();
                            folha.AppendChild(id);

                            XmlElement nome = xdoc.CreateElement("Nome");
                            nome.InnerText = item.Nome;
                            folha.AppendChild(nome);

                            XmlElement sobrenome = xdoc.CreateElement("Sobrenome");
                            sobrenome.InnerText = item.Sobrenome;
                            folha.AppendChild(sobrenome);

                            XmlElement cargo = xdoc.CreateElement("Cargo");
                            cargo.InnerText = item.IDCargo.ToString();
                            folha.AppendChild(cargo);

                            XmlElement lotacao = xdoc.CreateElement("Lotacao");
                            lotacao.InnerText = item.IDLotacao.ToString();
                            folha.AppendChild(lotacao);

                            XmlElement endereco = xdoc.CreateElement("Endereco");
                            endereco.InnerText = item.Endereco;
                            folha.AppendChild(endereco);

                            XmlElement municipio = xdoc.CreateElement("Municipio");
                            municipio.InnerText = item.IDMunicipio.ToString();
                            folha.AppendChild(municipio);

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
