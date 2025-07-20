using System;
using System.Threading;
using Confluent.Kafka;

class ChatConsumer
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

        consumer.Subscribe("chat-topic");

        Console.WriteLine("📥 Chat Receiver Started (press Ctrl+C to stop)");

        try
        {
            while (true)
            {
                var result = consumer.Consume(CancellationToken.None);
                Console.WriteLine($"💬 Message received: {result.Message.Value} [Offset: {result.Offset}]");
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("🔴 Consumer stopped.");
        }
        finally
        {
            consumer.Close();
        }
    }
}
