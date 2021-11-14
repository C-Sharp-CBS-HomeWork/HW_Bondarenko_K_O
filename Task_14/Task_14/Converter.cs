using System;
using System.Collections.Generic;
using System.Text;

namespace Task_14
{
    class Converter
    {
        private double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertFromGrn(double grn, int count)
        {
            switch (count)
            {
                case 1:
                    {
                        grn *= usd;
                        break;
                    }
                case 2:
                    {
                        grn *= eur;
                        break;
                    }
                case 3:
                    {
                        grn *= rub;
                        break;
                    }
            }
            return grn;
        }

        public double ConvertUsdToGrn(double currency)
        {
            currency *= 26.31;

            return currency;
        }

        public double ConvertEurToGrn(double currency)
        {
            currency *= 30.68;

            return currency;
        }
        public double ConvertRubToGrn(double currency)
        {
            currency *= 0.38;

            return currency;
        }
    }
}
