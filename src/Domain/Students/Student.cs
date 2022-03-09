using Disparo.Plataforma.Domain.PhoneNumbers;
using System.Collections.Generic;

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

        /// <summary>Endereço de e-mail institucional.</summary>
        public string Address { get; set; }
        
        /// <summary>Construtor com instanciação de um estudante para obter informações.</summary>
        /// <param name="enroll">Matrícula.</param>
        /// <param name="name">Nome.</param>
        /// <param name="address">Endereço de e-mail institucional.</param>
        /// <param name="phoneNumbers">Números para comunicação direta com o aluno.</param>
        public Student(string enroll, string name, string address, IEnumerable<PhoneNumber> phoneNumbers)
        {
            Enroll = enroll;
            Name = name;
            Address = address;
            PhoneNumbers = phoneNumbers;
        }
    }
}