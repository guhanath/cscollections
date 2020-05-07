using ConcoleColln.Contracts;
using System;
using System.Collections.Generic;

namespace ConcoleColln
{
    class Program
    {
        static void Main(string[] args)
        {
            IVatCalculator calc1 = new NationVatCalc(3, 2);
            IVatCalculator calc2 = new StateVatCalc(4, 5);
            CalcHandler<IVatCalculator> handler = new CalcHandler<IVatCalculator>();
            handler.AddCalcHandler(calc1);
            handler.AddCalcHandler(calc2);

            Console.WriteLine(handler.Calculate());

            //Pens
            List<IPens> penColors = new List<IPens>();
            //penColors.Add(new PenColors
            //{
                
            //});
            

            Console.ReadKey();
        }
    }

    public interface IVatCalculator
    {
        int Calculate();

    }

    public class StateVatCalc : IVatCalculator
    {
        private IVatCalculator _calc;
        private int _rate;
        private int _perc;

        public StateVatCalc(int rate, int perc)
        {
            this._rate = rate;
            this._perc = perc;
        }
        public int Calculate()
        {
            return _rate * _perc;
        }
    }

    public class NationVatCalc : IVatCalculator
    {
        private int _rate;
        private int _perc;

        public NationVatCalc(int rate, int perc)
        {
            this._rate = rate;
            this._perc = perc;
        }
        public int Calculate()
        {
            return _rate * _perc;
        }
    }


    public class CalcHandler<T> where T : IVatCalculator
    {
        delegate int VatCalc(int perc);
        private List<IVatCalculator> _calcs;

        public CalcHandler()
        {
            this._calcs = new List<IVatCalculator>();
        }

        public void AddCalcHandler(IVatCalculator calc)
        {
            _calcs.Add(calc);
        }
        public IEnumerable<int> Calculate()
        {
            foreach (var calc in _calcs)
            {
                yield return calc.Calculate();
            }

        }

    }
}
