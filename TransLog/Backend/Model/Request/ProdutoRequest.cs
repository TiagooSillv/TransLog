namespace Backend.Model.Request
{
    public class ProdutoRequest
    {
        public int Distancia { get; set; }
        public decimal Peso { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Comprimento { get; set; }
        public int ValorAdicional { get; set; }
    }
}
