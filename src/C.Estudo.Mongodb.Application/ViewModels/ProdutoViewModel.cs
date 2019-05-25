using System;
using System.Runtime.Serialization;

namespace C.Estudo.Mongodb.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [IgnoreDataMember]
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
