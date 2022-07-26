using CadastroPessoas.interfaces;
namespace CadastroPessoas.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public float? Rendimentos { get; set; }
        public string? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
}