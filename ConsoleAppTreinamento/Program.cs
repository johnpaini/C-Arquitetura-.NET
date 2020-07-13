namespace ConsoleAppTreinamento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Controller.Logic;

    class Program
    {
        static void Main(string[] args)
        {
            ClienteController controle = new ClienteController();

            for (int i = 0; i < 3; i++)
            {
                controle.Inserir();
            }

            controle.ListarTodos();
            Console.ReadKey();
        }
    }
}
