using System;
using System.Collections.Generic;
using System.Text;

namespace EXFinal8.Entidades
{
    internal class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public List<PedidoItem> Items { get; set; } = new List<PedidoItem>(); //nunca entra no construtor as listas//
        public Cliente Cliente { get; set; }

        public Pedido()
        {
        }

        public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(PedidoItem pedidoItem)
        {
            Items.Add(pedidoItem);
        }
        public void RemoveItem(PedidoItem pedidoItem)
        {
            Items.Remove(pedidoItem);
        }
        public double Total()
        {
 //aqui ele vai ficar percorredno a lista e chama o subtotal para calcular e o resultado fica no soma//
            double soma = 0.0;
            foreach (PedidoItem item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: " + Momento);
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente.Nome + " (" + Cliente.Email + ") - " + Cliente.Nascimento.ToString("dd/MM/yyyy"));
            sb.AppendLine("Itens do pedido:");
            foreach (PedidoItem item in Items)
            {
                sb.AppendLine(item.Produto.Nome + ", $" + item.Valor.ToString("F2") + ", Quantidade: " + item.Quantidade + ", Subtotal: $" + item.SubTotal().ToString("F2"));
            }
            sb.AppendLine("Total do pedido: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}



