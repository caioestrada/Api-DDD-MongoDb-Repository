using C.Estudo.Mongodb.Domain.Validations.GuidGenerator;
using MongoDB.Bson.Serialization.Attributes;
using System;

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
