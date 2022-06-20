using System.Collections.Generic;

namespace Hort.Etec.Apm.Domain.Emails
{
    /// <summary>Entidade que representa o e-mail de quem está enviando um conteúdo/mensagem.</summary>
    public class EmailEnvia
    {

        /// <summary>Construtor para instanciação de um email que será enviado. </summary>
        /// <param name="enderecoEmail">Endereço de quem está enviando.</param>
        /// <param name="senha">Senha de acesso ao e-mail.</param>
        /// <param name="proprietarioConta">Nome do proprietário da conta que está enviando o e-mail.</param>
        /// <param name="tituloEmail">Título do e-mail.</param>
        /// <param name="corpoEmail">Corpo do e-mail.</param>
        /// <param name="receptores">Receptores do e-mail.</param>
        public EmailEnvia(string enderecoEmail, string senha, string proprietarioConta, string tituloEmail, string corpoEmail, IEnumerable<ResponsavelRecebeEmail> receptores)
        {
            EnderecoEmail = enderecoEmail;
            Senha = senha;
            ProprietarioConta = proprietarioConta;
            TituloEmail = tituloEmail;
            CorpoEmail = corpoEmail;
            Receptores = receptores;
        }

        /// <summary>Construtor para instanciação de um email que será enviado. </summary>
        /// <param name="enderecoEmail">Endereço de quem está enviando.</param>
        /// <param name="senha">Senha de acesso ao e-mail.</param>
        /// <param name="proprietarioConta">Nome do proprietário da conta que está enviando o e-mail.</param>
        /// <param name="tituloEmail">Título do e-mail.</param>
        /// <param name="corpoEmail">Corpo do e-mail.</param>
        /// <param name="receptorAluno">Endereço de e-mail do estudante.</param>
        public EmailEnvia(string enderecoEmail, string senha, string proprietarioConta, string tituloEmail, string corpoEmail, AlunoRecebeEmail receptorAluno)
        {
            EnderecoEmail = enderecoEmail;
            Senha = senha;
            ProprietarioConta = proprietarioConta;
            TituloEmail = tituloEmail;
            CorpoEmail = corpoEmail;
            ReceptorAluno = receptorAluno;
        }

        /// Senha e email de acesso a conta, provisório.
        /// <summary>Endereço de quem está enviando.</summary>
        public string EnderecoEmail { get; set; }

        /// <summary>Senha de acesso ao e-mail.</summary>
        public string Senha { get; set; }

        /// <summary>Nome do proprietário da conta.</summary>
        public string ProprietarioConta { get; set; }

        /// <summary> Título do email.</summary>
        public string TituloEmail { get; set; }

        /// <summary>Corpo do e-mail.</summary>
        public string CorpoEmail { get; set; }

        /// <summary>Receptores do e-mail.</summary>
        public IEnumerable<ResponsavelRecebeEmail> Receptores { get; set; }

        /// <summary>Endereço de e-mail do estudante.</summary>
        public AlunoRecebeEmail ReceptorAluno { get; set; }
    }
}