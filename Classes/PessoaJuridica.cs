using CadastroPessoas.interfaces;
namespace CadastroPessoas.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidaCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}