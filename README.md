Projeto de rotina para trabalhar geração e processamento de dados usando Programação Orientada a Objetos (POO), broker MQTT  e exibição em Front-end.
Criar Aplicação que simule dados de sensor em campo, envie para um broker e exiba os dados em front-end para visualização.

Back-end: Publisher -> Broker MQTT -> Front-end: Subscriber

Entidade do sistema:
Sensor -> temperatura(°C), Umidade(%), Pressão(hPa), possui Nome e Valor

dotnet add package MQTTnet -> instalar pacote MQTT pelo terminal para iniciar
Separar back-end de front-end em pastas diferentes dentro do projeto para mais organização

Fluxo:
Criar Client -> Criar options (WithTcpServer( “broker.hivemq.com”))
-> Conectar ao Broker (client.ConnectAsync(options))
-> Gerar leitura do sensor (valor aleatório)
-> Armazenar leituras dos sensores em uma única classe
-> Instanciar objeto contendo da classe que contèm leituras de todos sensores
-> Transformar em JSON (JsonSerializer.Serialize(leitura))
-> Passar JSON para message
-> Publish
-> Conectar no front mqtt.connect(“wss://broker.hivemq.com:8884/mqtt”)
-> Ao conectar (client.on(“connect”,  => {})), Subscribe
-> Ao receber mensagem (client.on(“message”, (topic, message) => {}), converter dados vindos do MQTT para String (message.toString())
-> Converter String para objeto JS (JSON.Parse(‘mensagem’)).
