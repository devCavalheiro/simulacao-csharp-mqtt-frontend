using MQTTnet;

namespace simulacao_csharp_mqtt_frontend.back_end.Messaging;

public class MqttClientConnection
{
    public IMqttClient client;

    public MqttClientConnection()
    {
        var factory = new MqttClientFactory();
        client = factory.CreateMqttClient();
    }

    public async Task ConectarClient()
    {
        var options = new MqttClientOptionsBuilder()
            .WithTcpServer("broker.hivemq.com")
            .Build();

        await client.ConnectAsync(options);
    }
}
