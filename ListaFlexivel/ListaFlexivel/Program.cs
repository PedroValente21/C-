class Celula
{
    public int elemento;
    public Celula prox;
    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }
    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
}
class L1
{
    private Celula primeiro, ultimo;
    public L1()
    {
        ultimo = primeiro = new Celula();
    }
    public void Inserir(int x)
    {
        Celula i, tmp = new Celula(x);
        for (i = primeiro; i.prox != null && i.prox.elemento < x; i = i.prox) ;
        tmp.prox = i.prox;
        i.prox = tmp;
        if (primeiro == ultimo)
        {
            ultimo = ultimo.prox;
        }
    }
}
class L2
{
    private Celula primeiro;
    public L2()
    {
        primeiro.prox = primeiro = new Celula();
    }
    public void InserirA(int x)
    {
        Celula tmp = new Celula(x);
        tmp.prox = primeiro.prox;
        primeiro.prox = tmp;
    }
    public void InserirB(int x)
    {
        Celula i;
        for (i = primeiro; i.prox != primeiro; i = i.prox) ;
        Celula tmp = new Celula(x);
        tmp.prox = primeiro;
        i.prox = tmp;
    }
}