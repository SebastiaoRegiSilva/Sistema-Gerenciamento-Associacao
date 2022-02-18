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

        
        /// <summary>Construtor com instanciação de um estudante para obter informações. </summary>
        /// <param name="enroll">Matrícula.</param>
        /// <param name="name">Nome.</param>
        /// <param name="phoneNumbers">Números para comunicação direta com o aluno.</param>
        public Student(string enroll, string name, IEnumerable<PhoneNumber> phoneNumbers)
        {
            Enroll = enroll;
            Name = name;
            PhoneNumbers = phoneNumbers;
        }
    }
}