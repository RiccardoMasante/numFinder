using System;
using System.Collections.Generic;
using System.Text;

namespace numFinder
{
    public class BinarySearch : Search
    {
        
        public BinarySearch(BlackBox BB, string name, double FirstValueToBeTested) : base(BB, name, FirstValueToBeTested)
        {
            setValueFound(finder(base.getFirstValueToBeTested(), base.getFirstValueToBeTested()));
            
        }

        public double finder (double numberToBeTested,double interval)
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

        }

      
    }
}
