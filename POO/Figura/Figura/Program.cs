using System.Drawing;

public abstract class Figura
{
    protected int x { get; set; }
    protected int y { get; set; }
    protected int lado { get; set; }
    protected Color cor { get; set; }
    protected bool preenchimento { get; set; }

    public Figura (int x, int y, int lado, Color cor, bool preenchimento)
    {
        this.x = x;
        this.y = y;
        this.lado = lado;
        this.cor = cor;
        this.preenchimento = preenchimento;
    }

    public abstract void Desenha();
    public abstract void Area();
    public abstract void Perimetro();
}
class Quadrado : Figura
{
    public Quadrado(int x, int y, int lado, Color cor, bool preenchimento) : base (x, y, lado, cor, preenchimento){ }

    public override void Desenha()
    {
        Console.WriteLine($"Desenha um quadrado na posição ({x},{y}), com tamanho {lado} e cor {cor}");
    }
    public override void Area()
    {
        float area = (lado * lado);
        Console.WriteLine($"Area do quadrado = {area}");
    }
    public override void Perimetro()
    {
        float area = (lado * 4);
        Console.WriteLine($"Perimetro do triangulo = {area}");
    }
}

class Triangulo : Figura
{
    public Triangulo(int x, int y, int lado, Color cor, bool preenchimento) : base(x, y, lado, cor, preenchimento) { }
    public override void Desenha()
    {
        Console.WriteLine($"Desenha um quadrado na posição ({x},{y}), com tamanho {lado} e cor {cor}");
    }
    public override void Area()
    {
        float area = (lado * lado)/2;
        Console.WriteLine($"Area do triangulo = {area}");
    }
    public override void Perimetro()
    {
        float area = (lado * 3);
        Console.WriteLine($"Perimetro do triangulo = {area}");
    }
}

class Program
{
    public static Figura[] figuras = new Figura[10];
    public static int numfig = 0;

    public static void Main(string[] args)
    {
        figuras[numfig++] = new Quadrado(10, 20, 50, Color.Red, true);
        figuras[numfig++] = new Triangulo(20, 30, 60, Color.Blue, true);
        figuras[numfig++] = new Quadrado(30, 40, 70, Color.Green, false);

        for (int i = 0; i < numfig; i++)
        {
            figuras[i].Desenha();
            figuras[i].Area();
            figuras[i].Perimetro();
        }
    }
}