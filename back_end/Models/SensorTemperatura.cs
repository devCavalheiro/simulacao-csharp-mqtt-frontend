namespace simulacao_csharp_mqtt_frontend.back_end.Models;

public class SensorTemperatura : SensorBase
{
    private readonly Random random = new();

    public SensorTemperatura(string nome) : base(nome) { }

    public override int GerarValor() => random.Next(15, 20);
}
