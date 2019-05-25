using MongoDB.Bson.Serialization.Attributes;

namespace C.Estudo.Mongodb.Domain.Entities
{
    public class Produto
    {
        [BsonId]
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

    }
}
