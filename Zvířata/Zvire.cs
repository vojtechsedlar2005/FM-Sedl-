public abstract class Zvire
{
    public abstract string Druh {get;}
    public abstract int Vek {get;  set;}

    public Zvire(int vek)
    {
        Vek = vek;
    }

    public abstract void VydavaniZvuku ();
}

