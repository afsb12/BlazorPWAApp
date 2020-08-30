using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Interface
{
    interface IMesa
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public decimal ValorTotal { get; set; }
        public int QtdPessoas { get; set; }
        public IPedido Pedido { get; set; }
    }
}
