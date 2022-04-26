namespace Disparo.Plataforma.Domain.NumerosTelefones
{
    /// <summary>Possíveis tipos de número de telefone.</summary>
    public enum TipoTelefone
    {
        /// <summary>Número particular..</summary>
        Particular = 0,
        
        /// <summary>Número da empresa.</summary>
        Coorporativo = 1,
        
        /// <summary>Número do aparelho celular.</summary>
        Celular = 2,
        
        /// <summary>Número de telefone residencial.</summary>
        Casa = 3,
        
        /// <summary>Número utilizado para redes sociais.</summary>
        Social = 4
    }
}