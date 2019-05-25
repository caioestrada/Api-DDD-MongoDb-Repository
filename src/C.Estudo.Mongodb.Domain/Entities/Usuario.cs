using C.Estudo.Mongodb.Domain.Validations.GuidGenerator;
using MongoDB.Bson.Serialization.Attributes;
using System;

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
