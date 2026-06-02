using System.Text.Json;
using MQTTnet;
using simulacao_csharp_mqtt_frontend.back_end.Models;

namespace simulacao_csharp_mqtt_frontend.back_end.Messaging;

public class MqttPublisher
{
    public IMqttClient clientPublisher;

    public MqttPublisher(MqttClientConnection clientConnection)
    {
        clientPublisher = clientConnection.client;
    }

    public async Task PublicarMensagem(LeituraSensores leitura)
    {
        string json = JsonSerializer.Serialize(leitura);

        var message = new MqttApplicationMessageBuilder()
            .WithTopic("gabriel/dados")
            .WithPayload(json)
            .Build();

        await clientPublisher.PublishAsync(message);
    }
}
