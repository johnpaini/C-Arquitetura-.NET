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
    /// Summary description for WSFuncionarios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSFuncionarios : System.Web.Services.WebService
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
                FuncionariosController controle = new FuncionariosController();
                xdoc = controle.ListarFuncionariosXML();
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
        public XmlElement ListarCargos()
        {
            XmlDocument xdoc = null;
            try
            {
                CargosController controle = new CargosController();
                xdoc = controle.ListarCargosXML();
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
        public XmlElement ListarLotacoes()
        {
            XmlDocument xdoc = null;
            try
            {
                LotacoesController controle = new LotacoesController();
                xdoc = controle.ListarLotacoesXML();
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
        public XmlElement ListarMunicipio()
        {
            XmlDocument xdoc = null;
            try
            {
                MunicipiosController controle = new MunicipiosController();
                xdoc = controle.ListarMunicipiosXML();
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
        public XmlElement ListarEstado()
        {
            XmlDocument xdoc = null;
            try
            {
                EstadosController controle = new EstadosController();
                xdoc = controle.ListarEstadosXML();
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
