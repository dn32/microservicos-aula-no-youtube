using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Consumidor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "[adicione sua url aqui]"
            };

            while (true)
            {
                var response = await client.ReceiveMessageAsync(request);

                foreach (var mensagem in response.Messages)
                {
                    Console.WriteLine(mensagem.Body);
                    await client.DeleteMessageAsync("[adicione sua url aqui]", mensagem.ReceiptHandle);
                }
            }
        }
    }
}
