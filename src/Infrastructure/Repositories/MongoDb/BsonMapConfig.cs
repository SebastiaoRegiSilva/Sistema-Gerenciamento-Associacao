using Repositories.MongoDb.Alunos.Models;
using Repositories.MongoDb.Armarios.Models;
using Repositories.MongoDb.Classes.Models;
using Repositories.MongoDb.Emails.Models;
using Repositories.MongoDb.Predios.Models;
using Repositories.MongoDb.Responsaveis.Models;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb
{
    /// <summary>Classe de configuração responsável pelo mapeamento geral dos modelos na base de dados.</summary>
    public static class BsonMapConfig
    {
        /// <summary>Variável que verifica se o método já foi acessado por outro contexto.</summary>
        private static bool _hit = false;

        /// <summary>Método de mapeamento dos modelos.</summary>
        public static void Config()
        {
            if (_hit)
                return;

            BsonClassMap.RegisterClassMap<AlunoModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
            });

            BsonClassMap.RegisterClassMap<ArmarioModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
            });

            BsonClassMap.RegisterClassMap<ClasseModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
            });

            BsonClassMap.RegisterClassMap<EmailModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
            });

            BsonClassMap.RegisterClassMap<PredioModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
            });

            BsonClassMap.RegisterClassMap<ResponsavelModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
            });

            _hit = true;
        }
    }
}