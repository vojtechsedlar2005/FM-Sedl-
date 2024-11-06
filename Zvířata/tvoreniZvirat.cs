public class Pes: Zvire
{
    public Pes(int vek) : base(vek) {}
    public override string Druh => "Pes" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("Haf!");
    }

}

public class Kocka: Zvire
{
    public Kocka(int vek) : base(vek) {}
    public override string Druh => "Kočka" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("Mňaaaau!");
    }
}

public class BatynomusVelký: Zvire
{
    public BatynomusVelký(int vek) : base(vek) {}
    public override string Druh => "Batynomus velký" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("SSSSS!");
    }
}

public class PandaVosí: Zvire
{
    public PandaVosí(int vek) : base(vek) {}
    public override string Druh => "Vosa pandí" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("Bzzzzz!");
    }
}

public class KsukolOcasatý: Zvire
{
    public KsukolOcasatý(int vek) : base(vek) {}
    public override string Druh => "Ksukol ocasatý" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("Píííí!");
    }
}
public class TlustohlavecTasmánský: Zvire
{
    public TlustohlavecTasmánský(int vek) : base(vek) {}
    public override string Druh => "Tlustohlavec tasmánský" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("------");
    }
}

public class Frcek: Zvire
{
    public Frcek(int vek) : base(vek) {}
    public override string Druh => "Frček" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("Písk!");
    }
}
public class RyposLysy: Zvire
{
    public RyposLysy(int vek) : base(vek) {}
    public override string Druh => "Rypoš lysý" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("Pískk!");
    }
}
public class Mihule: Zvire
{
    public Mihule(int vek) : base(vek) {}
    public override string Druh => "Mihule" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("@#&@đĐ[]nevim!");
    }
}
public class KahauNosaty: Zvire
{
    public KahauNosaty(int vek) : base(vek) {}
    public override string Druh => "Kahau nosatý" ;
    public override void VydavaniZvuku() 
    {
        Console.WriteLine("KuckKuck");
    }
}





