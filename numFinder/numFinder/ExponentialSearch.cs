using System;
using System.Collections.Generic;
using System.Text;

namespace numFinder
{
    public class ExponentialSearch : BinarySearch
    {
        private double startValue;   
        public ExponentialSearch(BlackBox BB, string name, double FirstValueToBeTested) : base(BB, name, FirstValueToBeTested)
        {
            startValue = presetValue(FirstValueToBeTested);
            if (!base.iterationControl())
                setValueFound(base.finder(this.startValue, this.startValue));
            else
                setValueFound(startValue);
            
        }

        private double presetValue(double numberToBeTested)
        {
            base.setNumberOfIteration(base.getNumberOfIteration() + 1);
            if (base.iterationControl())
                return numberToBeTested;
            if (base.getBlackBox().IsGreatherThen(numberToBeTested))
                return numberToBeTested;
            else
                return presetValue( numberToBeTested *2);
        }

       /* private double finder (double numberToBeTested,double interval)
        {
            
            base.setNumberOfIteration(base.getNumberOfIteration()+1);
            if (base.iterationControl())
                return numberToBeTested;
            if (interval < base.getBlackBox().getAccuracy())
                if (base.getBlackBox().IsGreatherThen(numberToBeTested))
                    return numberToBeTested - interval / 2;
                else
                    return numberToBeTested + interval / 2;
            if (base.getBlackBox().IsGreatherThen(numberToBeTested))
                return finder(numberToBeTested - interval / 2, interval / 2);
            else
                return finder(numberToBeTested + interval / 2, interval / 2);

        }*/

      
    }
}
