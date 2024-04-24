namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>();

            animali.Add(new Cane());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());
            animali.Add(new Delfino());

            foreach (Animale animale in animali)
            {
                animale.Dormi();
                animale.Verso();
                animale.Mangia();
                animale.CheAnimale();

                if (animale is IVolante)
                {
                    IVolante volante = (IVolante)animale;
                    FaiVolare(volante);
                }

                if (animale is INuotante)
                {
                    INuotante nuotante = (INuotante)animale;
                    FaiNuotare(nuotante);
                }
            }
        }

        // Metodi statici per far volare e nuotare

        public static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        public static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }
    }
}
