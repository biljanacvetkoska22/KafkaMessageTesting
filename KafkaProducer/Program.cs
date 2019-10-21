using KafkaNet;
using KafkaNet.Model;
using KafkaNet.Protocol;
using System;

namespace Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new KafkaOptions(new Uri("http://localhost:9092"));

            var router = new BrokerRouter(options);

            var client = new KafkaNet.Producer(router);
            client.SendMessageAsync("testtopic", new[]
                                    { new Message(" car { brand-name: ferrari, model: 1, doors-number: 2, sports: 0 } ") }).Wait();

            Console.ReadLine();
        }
    }
}