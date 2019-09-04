namespace ClassesAbstratas.Entidades
{
    class Individual : Contribuinte
    {
        public double GastoSaude { get; set; }

        public Individual()
        {
        }

        public Individual(string nome, double rendimentoAnual, double gastoSaude) : base(nome, rendimentoAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Taxa()
        {
            if (RendimentoAnual < 20000.0)
            {
                return RendimentoAnual * 0.15 - GastoSaude * 0.5;
            }
            else
            {
                return RendimentoAnual * 0.25 - GastoSaude * 0.5;
            }
        }
    }
}
