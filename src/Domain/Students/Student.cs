using System.Collections.Generic;
using Disparo.Plataforma.Domain.PhoneNumbers;

namespace Disparo.Plataforma.Domain.Students
{
    /// <summary>Entidade que representa os estudantes.</summary>
    public class Student
    {
        /// <summary>Matrícula.</summary>
        public string Enroll { get; set; }

        /// <summary>Nome.</summary>
        public string Name { get; set; }

        /// <summary>Números para comunicação direta com o aluno.</summary>
        public IEnumerable<PhoneNumber> PhoneNumbers { get; set; }
    }
}