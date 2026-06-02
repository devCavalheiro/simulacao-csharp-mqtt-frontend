namespace simulacao_csharp_mqtt_frontend.back_end.Models;

public class SensorPressao : SensorBase
{
    private readonly Random random = new();

    public SensorPressao(string nome) : base(nome) { }

    public override int GerarValor() => random.Next(980, 1030);
}
