using System;

namespace Hort.Etec.Apm.Domain.Alunos.Exceptions
{
    /// <summary>Exceção da regra de negócio.</summary>
    public class BusinessException : Exception
    {

        /// <summary>Construtor padrão.</summary>
        /// <param name="mensagem">Mensagem com maiores informações da exceção gerada pela regra de negócio.</param>
        /// <returns>Conteúdo do erro.</returns>
        public BusinessException(string mensagem) :
            base(mensagem)
        {
        }

        /// <summary>Dados relacionados a exceção, úteis para o retorno.</summary>
        public object Dados { get; protected set; }
    }
}