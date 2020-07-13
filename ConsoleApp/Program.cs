namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Logic;

    class Program
    {
        static void Main(string[] args)
        {
            ClientesView view = new ClientesView();
            view.ListarTodos();
            Console.ReadKey();
            //view.Inserir();
            //view.Remover();
            //view.Listar();
            view.ImprimirXML();
            view = null;
            Console.ReadKey();
        }
    }
}
