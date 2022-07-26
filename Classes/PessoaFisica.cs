using CadastroPessoas.interfaces;
namespace CadastroPessoas.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? Cpf { get; set; }
        public DateTime dataNasc { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidaDataNasc(DateTime datanasc)
        {
            throw new NotImplementedException();
        }
    }
}