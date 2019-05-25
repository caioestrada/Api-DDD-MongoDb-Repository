using MongoDB.Bson.Serialization.Attributes;

namespace C.Estudo.Mongodb.Domain.Entities
{
    public class Usuario
    {
        [BsonId]
        public string Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
