using System;
using System.Collections.Generic;
using System.Text;

namespace numFinder
{
    public class LinearSearch : Search
    {
        
        public LinearSearch(BlackBox BB,string name, double FirstValueToBeTested) : base(BB,name, FirstValueToBeTested)
        {
            base.setFirstValueToBeTested(0);
            setValueFound(finder(base.getFirstValueToBeTested(), true));

        }

        private double finder (double numberToBeTested, bool increase)
        {
            base.setNumberOfIteration(base.getNumberOfIteration()+1);
            if (base.iterationControl() )
                return numberToBeTested;
            if (base.getNumberOfIteration() == 1)
            {
                if (base.getBlackBox().IsGreatherThen(numberToBeTested))
                    return finder(numberToBeTested - base.getBlackBox().getAccuracy(), false);
                else
                    return finder(numberToBeTested + base.getBlackBox().getAccuracy(), true);
            }
            else
            {
                if (increase)
                {
                    if (base.getBlackBox().IsGreatherThen(numberToBeTested))
                        return numberToBeTested;
                    else
                        return finder(numberToBeTested + base.getBlackBox().getAccuracy(), true);
                }
                else
                {
                    if (base.getBlackBox().IsGreatherThen(numberToBeTested))
                        return finder(numberToBeTested - base.getBlackBox().getAccuracy(), false);
                    else
                        return numberToBeTested;
                }
            }

        }

        
    }
}
