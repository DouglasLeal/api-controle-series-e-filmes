namespace App.Models
{
    public abstract class Midia
    {
        public int Id { get; set; }
        public string? TituloOriginal { get; set; }
        public string? TituloBrasileiro { get; set; }
        public string? Descricao { get; set; }
        public int Nota { get; set; }
        public DateTime? Lancamento { get; set; }
        public Genero? Genero { get; set; }
    }

    public enum Genero
    {
        Acao,
        Comedia,
        Drama,
        Romance,
        Documentario,
        Suspense,
        Terror,
        FiccaoCientifica
    }
}
