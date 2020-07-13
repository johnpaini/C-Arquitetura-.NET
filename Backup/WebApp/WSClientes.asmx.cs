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
    /// Summary description for WSClientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSClientes : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public XmlElement Listar()
        {
            XmlDocument xdoc = null;
            try
            {
                ClientesController controle = new ClientesController();
                xdoc = controle.ListarTodosXML();
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
