namespace ClassesAbstratas.Entidades
{
    class Companhia : Contribuinte
    {
        public int NumEmpregados { get; set; }

        public Companhia()
        {
        }

        public Companhia(string nome, double rendimentoAnual, int numEmpregados) : base(nome, rendimentoAnual)
        {
            NumEmpregados = numEmpregados;
        }

        public override double Taxa()
        {
            if (NumEmpregados > 10)
            {
                return RendimentoAnual * 0.14;
            }
            else
            {
                return NumEmpregados * 0.16;
            }
        }
    }
}
