class Alarme
{
    public delegate void Acordar(string mensagem);
    public event Acordar TempoEsgotado;

    public void DisparaEvento()
    {
        AoEsgotarTempo();
    }

    public void AoEsgotarTempo()
    {
        if (TempoEsgotado != null)
        {
            TempoEsgotado("Tempo esgotado!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Alarme alarme = new Alarme();

        alarme.TempoEsgotado += MensagemConsole;
        alarme.DisparaEvento();
        alarme.TempoEsgotado += MensagemConsole2;
        alarme.DisparaEvento();
        alarme.TempoEsgotado -= MensagemConsole;
        alarme.DisparaEvento();
    }

    public static void MensagemConsole(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void MensagemConsole2(string mensagem)
    {
        Console.WriteLine("Mensagem2");
    }
}