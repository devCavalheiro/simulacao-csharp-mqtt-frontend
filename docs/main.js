console.log("Conectando...");
const client = mqtt.connect("wss://broker.hivemq.com:8884/mqtt");

const textoStatus = document.getElementById("status");
const temperatura = document.getElementById("temperatura");
const umidade = document.getElementById("umidade");
const pressao = document.getElementById("pressao");

client.on("connect", () => {
  client.subscribe("gabriel/dados");
  console.log("Conectado.");

  textoStatus.textContent = "Conectado";
  textoStatus.style.color = "green";
});

client.on("message", (topic, message) => {
  const conteudo = message.toString();
  const dados = JSON.parse(conteudo);

  temperatura.textContent = dados.temperatura + "°C";
  umidade.textContent = dados.umidade + "%";
  pressao.textContent = dados.pressao + " hPa";
});
