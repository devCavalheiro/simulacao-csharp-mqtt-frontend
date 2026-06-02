using simulacao_csharp_mqtt_frontend.back_end.Messaging;
using simulacao_csharp_mqtt_frontend.back_end.Models;

Console.Clear();

// Conexão do Client

MqttClientConnection client = new();

Console.WriteLine("Conectando...");
await client.ConectarClient();
Console.WriteLine("Conectado.");

// Client Conectando ao Broker V

// // // // // //

// Gerar Leitura dos sensores

SensorTemperatura sensorTemperatura = new("Temperatura");
SensorUmidade sensorUmidade = new("Umidade");
SensorPressao sensorPressao = new("Pressão");

// Armazenar em uma classe

// // // // // //

// Publicar mensagem

MqttPublisher publisher = new(client);

while (true)
{
    LeituraSensores leitura = new()
    {
        temperatura = sensorTemperatura.GerarValor(),
        umidade = sensorUmidade.GerarValor(),
        pressao = sensorPressao.GerarValor(),
    };

    await publisher.PublicarMensagem(leitura);
    await Task.Delay(5000);
}

// Mensagem publicada