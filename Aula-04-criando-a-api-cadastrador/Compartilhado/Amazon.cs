using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Model;
using System.Threading.Tasks;

namespace Compartilhado
{
    public static class Amazon
    {
        public static async Task SalvarAsync(this Pedido pedido)
        {
            var client = new AmazonDynamoDBClient(RegionEndpoint.SAEast1);
            var context = new DynamoDBContext(client);
            await context.SaveAsync(pedido);
        }
    }
}
