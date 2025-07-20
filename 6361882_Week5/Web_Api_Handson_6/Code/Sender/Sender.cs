using System;
using Confluent.Kafka;
using System.Threading.Tasks;

namespace KafkaSender
{
    internal class Sender
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("Kafka Chat Sender Started (type 'exit' to quit):");

            while (true)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                    break;

                var message = new Message<Null, string> { Value = input };

                try
                {
                    var result = await producer.ProduceAsync("chat-topic", message);
                    Console.WriteLine($"Sent to: {result.TopicPartitionOffset}");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Error: {e.Error.Reason}");
                }
            }

            Console.WriteLine("Sender stopped.");
        }
    }
}
