namespace Disparo.Plataforma.Domain.Answerables
{
    /// <summary>Entidade que representa os pais ou responsáveis pelos alunos.</summary>
    public class Answerable
    {
        /// <summary>Cadastro de pessoa física.</summary>
        public string Cpf { get; set; }

        /// <summary>Nome dos pais ou responsáveis.</summary>
        public string Name { get; set; }
    
        /// <summary>Endereço de e-mail dos pais ou responsáveis.</summary>
        public string AdrressEmail { get; set; }
    }
}