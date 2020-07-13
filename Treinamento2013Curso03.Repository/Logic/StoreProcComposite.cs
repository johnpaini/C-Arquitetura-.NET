namespace Treinamento2013Curso03.Repository.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

    using System.Xml;
    using System.Data.Objects.DataClasses;

    public class StoreProcComposite
    {
        public XmlDocument ListarFuncionariosXML(List<PR_ListarFuncionarios_Result> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Funcionarios");
                {
                    foreach (PR_ListarFuncionarios_Result item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Funcionario");
                        {
                            XmlElement id = xdoc.CreateElement("IDFuncionario");
                            id.InnerText = item.IDFuncionario.ToString();
                            folha.AppendChild(id);

                            XmlElement nome = xdoc.CreateElement("Nome");
                            nome.InnerText = item.Nome;
                            folha.AppendChild(nome);

                            XmlElement sobrenome = xdoc.CreateElement("Sobrenome");
                            sobrenome.InnerText = item.Sobrenome;
                            folha.AppendChild(sobrenome);

                            XmlElement cargo = xdoc.CreateElement("Cargo");
                            cargo.InnerText = item.DescricaoCargo;
                            folha.AppendChild(cargo);

                            XmlElement lotacao = xdoc.CreateElement("Lotacao");
                            lotacao.InnerText = item.DescricaoLotacao;
                            folha.AppendChild(lotacao);

                            XmlElement endereco = xdoc.CreateElement("Endereco");
                            endereco.InnerText = item.Endereco;
                            folha.AppendChild(endereco);

                            XmlElement municipio = xdoc.CreateElement("Municipio");
                            municipio.InnerText = item.DescricaoMunicipio;
                            folha.AppendChild(municipio);

                            XmlElement uf = xdoc.CreateElement("UF");
                            uf.InnerText = item.Sigla;
                            folha.AppendChild(uf);

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

        public XmlDocument ListarFuncionariosPorCargoXML(List<PR_ListarFuncionariosPorCargo_Result> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("FuncionariosPorCargo");
                {
                    foreach (PR_ListarFuncionariosPorCargo_Result item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Funcionario");
                        {
                            XmlElement id = xdoc.CreateElement("IDFuncionario");
                            id.InnerText = item.IDFuncionario.ToString();
                            folha.AppendChild(id);

                            XmlElement nome = xdoc.CreateElement("Nome");
                            nome.InnerText = item.Nome;
                            folha.AppendChild(nome);

                            XmlElement sobrenome = xdoc.CreateElement("Sobrenome");
                            sobrenome.InnerText = item.Sobrenome;
                            folha.AppendChild(sobrenome);

                            XmlElement cargo = xdoc.CreateElement("Cargo");
                            cargo.InnerText = item.DescricaoCargo;
                            folha.AppendChild(cargo);

                            XmlElement lotacao = xdoc.CreateElement("Lotacao");
                            lotacao.InnerText = item.DescricaoLotacao;
                            folha.AppendChild(lotacao);

                            XmlElement endereco = xdoc.CreateElement("Endereco");
                            endereco.InnerText = item.Endereco;
                            folha.AppendChild(endereco);

                            XmlElement municipio = xdoc.CreateElement("Municipio");
                            municipio.InnerText = item.DescricaoMunicipio;
                            folha.AppendChild(municipio);

                            XmlElement uf = xdoc.CreateElement("UF");
                            uf.InnerText = item.Sigla;
                            folha.AppendChild(uf);

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

        public XmlDocument ListarFuncionariosPorLotacaoXML(List<PR_ListarFuncionariosPorLotacao_Result> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("FuncionariosPorLotacao");
                {
                    foreach (PR_ListarFuncionariosPorLotacao_Result item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Funcionario");
                        {
                            XmlElement id = xdoc.CreateElement("IDFuncionario");
                            id.InnerText = item.IDFuncionario.ToString();
                            folha.AppendChild(id);

                            XmlElement nome = xdoc.CreateElement("Nome");
                            nome.InnerText = item.Nome;
                            folha.AppendChild(nome);

                            XmlElement sobrenome = xdoc.CreateElement("Sobrenome");
                            sobrenome.InnerText = item.Sobrenome;
                            folha.AppendChild(sobrenome);

                            XmlElement cargo = xdoc.CreateElement("Cargo");
                            cargo.InnerText = item.DescricaoCargo;
                            folha.AppendChild(cargo);

                            XmlElement lotacao = xdoc.CreateElement("Lotacao");
                            lotacao.InnerText = item.DescricaoLotacao;
                            folha.AppendChild(lotacao);

                            XmlElement endereco = xdoc.CreateElement("Endereco");
                            endereco.InnerText = item.Endereco;
                            folha.AppendChild(endereco);

                            XmlElement municipio = xdoc.CreateElement("Municipio");
                            municipio.InnerText = item.DescricaoMunicipio;
                            folha.AppendChild(municipio);

                            XmlElement uf = xdoc.CreateElement("UF");
                            uf.InnerText = item.Sigla;
                            folha.AppendChild(uf);

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

        public XmlDocument ListarMunicipiosXML(List<PR_ListarMunicipios_Result> lista)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();

                XmlElement raiz = xdoc.CreateElement("Municipios");
                {
                    foreach (PR_ListarMunicipios_Result item in lista)
                    {
                        XmlElement folha = xdoc.CreateElement("Municipio");
                        {
                            XmlElement id = xdoc.CreateElement("IDMunicipio");
                            id.InnerText = item.IDMunicipio.ToString();
                            folha.AppendChild(id);

                            XmlElement nome = xdoc.CreateElement("DescricaoMunicipio");
                            nome.InnerText = item.DescricaoMunicipio;
                            folha.AppendChild(nome);

                            XmlElement uf = xdoc.CreateElement("UF");
                            uf.InnerText = item.Sigla;
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
