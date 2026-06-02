namespace simulacao_csharp_mqtt_frontend.back_end.Models;

public abstract class SensorBase
{
    public string Nome { get; private set; }
    public double Valor { get; protected set; }

    public SensorBase(string nome)
    {
        Nome = nome;
    }

    public abstract int GerarValor();
}
