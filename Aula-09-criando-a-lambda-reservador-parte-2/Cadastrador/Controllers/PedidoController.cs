using System;
using System.Threading.Tasks;
using Compartilhado;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Cadastrador.Controllers
{
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        public async Task PostAsync([FromBody] Pedido pedido)
        {
            pedido.Id = Guid.NewGuid().ToString();
            pedido.DataDeCriacao = DateTime.Now;

            await pedido.SalvarAsync();

            Console.WriteLine($"Pedido salvo com sucesso: id {pedido.Id}");
        }
    }
}
