namespace conceptsPOO
{
    public class ComissionByEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sale { get; set; }

        public override decimal GetValueToPay()
        {
            return Sale * (decimal)CommissionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Comision Percentaje: {$"{CommissionPercentaje:P2}",18}" +
                $"\n\t Sales..............: {$"{ Sale:C2}",18}" +
                $"\n\t Value to pay.......: {$"{GetValueToPay():C2}",18}";
        }
    }
}
