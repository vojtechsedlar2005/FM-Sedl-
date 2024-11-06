public static class VytvorZvire
{
    public static Zvire VytvorPsa(int vek) => new Pes(vek);
    public static Zvire VytvorKocku(int vek) => new Kocka(vek);
    public static Zvire VytvorBatynomaVelkeho(int vek) => new BatynomusVelký(vek);
    public static Zvire VytvorPanduVosi(int vek) => new PandaVosí(vek);
    public static Zvire VytvorKsukolaOcasateho(int vek) => new KsukolOcasatý(vek);
    public static Zvire VytvorTlustohlavceTasmanskeho(int vek) => new TlustohlavecTasmánský(vek);
    public static Zvire VytvorFrcka(int vek) => new Frcek(vek);
    public static Zvire VytvorRyposeLyseho(int vek) => new RyposLysy(vek);
    public static Zvire VytvorMihuli(int vek) => new Mihule(vek);
    public static Zvire VytvorKahauaNosateho(int vek) => new KahauNosaty(vek);
}