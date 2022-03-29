using Disparo.Plataforma.Domain.NumerosTelefones;
using System.Collections.Generic;

namespace Disparo.Plataforma.Domain.Aluno
{
    /// <summary>Entidade que representa os estudantes.</summary>
    public class Aluno
    {
        /// <summary>Matrícula.</summary>
        public string Matricula { get; set; }

        /// <summary>Nome.</summary>
        public string Nome { get; set; }

        /// <summary>Números para comunicação direta com o aluno.</summary>
        public IEnumerable<NumeroTelefone> NumerosTelefones { get; set; }

        /// <summary>Endereço de e-mail institucional.</summary>
        public string EnderecoEmail { get; set; }
        
        /// <summary>Construtor com instanciação de um estudante para obter informações.</summary>
        /// <param name="matricula">Matrícula.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="enderecoEmail">Endereço de e-mail institucional.</param>
        /// <param name="numerosTelefones">Números para comunicação direta com o aluno.</param>
        public Aluno(string matricula, string nome, string enderecoEmail, IEnumerable<NumeroTelefone> numerosTelefones)
        {
            Matricula = matricula;
            Nome = nome;
            EnderecoEmail = enderecoEmail;
            NumerosTelefones = numerosTelefones;
        }
    }
}