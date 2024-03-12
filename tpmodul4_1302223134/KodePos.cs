namespace tpmodul4_1302223134;

internal class KodePos
{
    public enum enumKelurahan
    {
        Batununggal, Kujangsari,
        Mengger, Wates, Cijaura,
        Jatisari, Margasari,
        Sekejati, Kebonwaru,
        Maleer, Samoja
    }

    public int getKodePos(enumKelurahan kelurahan)
    {
        int[] kodepos = {
            40266, 40287, 40267, 40256,
            40287, 40286, 40286, 40286,
            40272, 40274, 40273
        };
        return kodepos[(int)kelurahan];
    }
}
