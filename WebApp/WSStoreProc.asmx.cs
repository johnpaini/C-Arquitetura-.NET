namespace WebApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Services;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;
    using Treinamento2013Curso03.Repository.Logic;
    using Treinamento2013Curso03.Controller.Logic;

    using System.Xml;

    /// <summary>
    /// Summary description for WSStoreProc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSStoreProc : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public XmlElement ListarFuncionarios()
        {
            XmlDocument xdoc = null;
            try
            {
                StoreProcController controle = new StoreProcController();
                xdoc = controle.ListarTodosFuncionariosXML();
            }
            catch (Exception ex)
            {
                xdoc = new XmlDocument();
                {
                    XmlElement raiz = xdoc.CreateElement("Erro");
                    {
                        XmlElement erro = xdoc.CreateElement("Mensagem");
                        erro.InnerText = ex.Message;
                        raiz.AppendChild(erro);
                    }
                    xdoc.AppendChild(raiz);
                }
            }
            return xdoc.DocumentElement;
        }

        [WebMethod]
        public XmlElement ListarFuncionariosPorCargo(int idCargo)
        {
            XmlDocument xdoc = null;
            try
            {
                StoreProcController controle = new StoreProcController();
                xdoc = controle.ListarTodosFuncionariosPorCargoXML(idCargo);
            }
            catch (Exception ex)
            {
                xdoc = new XmlDocument();
                {
                    XmlElement raiz = xdoc.CreateElement("Erro");
                    {
                        XmlElement erro = xdoc.CreateElement("Mensagem");
                        erro.InnerText = ex.Message;
                        raiz.AppendChild(erro);
                    }
                    xdoc.AppendChild(raiz);
                }
            }
            return xdoc.DocumentElement;
        }

        [WebMethod]
        public XmlElement ListarFuncionariosPorLotacao(int idLotacao)
        {
            XmlDocument xdoc = null;
            try
            {
                StoreProcController controle = new StoreProcController();
                xdoc = controle.ListarTodosFuncionariosPorLotacaoXML(idLotacao);
            }
            catch (Exception ex)
            {
                xdoc = new XmlDocument();
                {
                    XmlElement raiz = xdoc.CreateElement("Erro");
                    {
                        XmlElement erro = xdoc.CreateElement("Mensagem");
                        erro.InnerText = ex.Message;
                        raiz.AppendChild(erro);
                    }
                    xdoc.AppendChild(raiz);
                }
            }
            return xdoc.DocumentElement;
        }

        [WebMethod]
        public XmlElement ListarMunicipios()
        {
            XmlDocument xdoc = null;
            try
            {
                StoreProcController controle = new StoreProcController();
                xdoc = controle.ListarTodosMunicipiosXML();
            }
            catch (Exception ex)
            {
                xdoc = new XmlDocument();
                {
                    XmlElement raiz = xdoc.CreateElement("Erro");
                    {
                        XmlElement erro = xdoc.CreateElement("Mensagem");
                        erro.InnerText = ex.Message;
                        raiz.AppendChild(erro);
                    }
                    xdoc.AppendChild(raiz);
                }
            }
            return xdoc.DocumentElement;
        }
    }
}
