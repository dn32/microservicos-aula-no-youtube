using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Model;
using System.Collections.Generic;
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

        public static T ToObject<T>(this Dictionary<string, AttributeValue> dictionary)
        {
            var client = new AmazonDynamoDBClient(RegionEndpoint.SAEast1);
            var context = new DynamoDBContext(client);

            var doc = Document.FromAttributeMap(dictionary);
            return context.FromDocument<T>(doc);
        }
    }
}
