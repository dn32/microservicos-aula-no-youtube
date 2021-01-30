using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Fornecedor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new SendMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/355552168393/teste",
                MessageBody = "teste 123"
            };

            await client.SendMessageAsync(request);
        }
    }
}
