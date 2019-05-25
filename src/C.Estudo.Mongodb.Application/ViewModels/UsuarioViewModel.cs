using System;
using System.Runtime.Serialization;

namespace C.Estudo.Mongodb.Application.ViewModels
{
    public class UsuarioViewModel
    {
        [IgnoreDataMember]
        public string Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
