namespace Model
{
    public class Produto
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public int Quantidade { get; set; }
        
        public bool Reservado { get; set; }
    }
}
