namespace ConsoleAppTreinamento.ModelData.Logic
{
    using System;

    public class Cliente
    {
        public Cliente() { }

        //private string nome;
        //public string Nome
        //{
        //    get { return this.nome; }
        //    set { this.nome = value; }
        //}

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cargo { get; set; }
        public string Lotacao { get; set; }
        public string Telefone { get; set; }
    }
}
