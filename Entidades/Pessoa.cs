namespace Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Idade { get; set; }
        

        public override string ToString()
        {
            return $"{Nome} {Sobrenome} tem  {Idade} anos.";
        }
    }
}
