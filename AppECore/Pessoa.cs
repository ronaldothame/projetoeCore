namespace cadastro
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        private FaixaEtaria faixaEtaria;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            SetFaixaEtaria(idade);
        }     
        
        private void SetFaixaEtaria(int idade)
        {
            if (idade <= 12)
            {
                this.faixaEtaria = FaixaEtaria.Criança;
            }
            else if (idade <= 19)
            {
                this.faixaEtaria = FaixaEtaria.Adolescente;
            }
            else if (idade <=65)
            {
                this.faixaEtaria = FaixaEtaria.Adulto;
            }
            else
            {
                this.faixaEtaria = FaixaEtaria.Idoso;
            }
        }
        public void Print()
        {
            Console.WriteLine("Nome: " + this.nome + "\tIdade: " + this.idade + "\tFaixa Etária: " + this.faixaEtaria);
        }
    }
    public enum FaixaEtaria
    {
        Criança,
        Adolescente,
        Adulto,
        Idoso
    }
}
