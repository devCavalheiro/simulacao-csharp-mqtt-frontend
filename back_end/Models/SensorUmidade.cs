namespace simulacao_csharp_mqtt_frontend.back_end.Models;

public class SensorUmidade : SensorBase
{
    private readonly Random random = new();

    public SensorUmidade(string nome) : base(nome) { }

    public override int GerarValor() => random.Next(30, 90);
}
