using System;
using System.Collections.Generic;
using System.Text;

namespace numFinder
{
    public class BlackBox
    {
        private double _TheNumber;
        private double accuracy;
        private int maximumNumberOfIterations;
        public BlackBox (double num)
        {
            this._TheNumber = num;
        }
        public bool IsGreatherThen(double guess)
        {
            return (guess > _TheNumber) ? true : false;
        }
        public void set_TheNumber(double num)
        {
            this._TheNumber = num;
        }
        public void setAccuracy (double acc)
        {
            this.accuracy = acc;
        }

        public void setMaximumNumberOfIterations(int maxIter)
        {
            this.maximumNumberOfIterations = maxIter;
        }

        public double getAccuracy()
        {
            return this.accuracy;
        }
        public int getMaximumNumberOfIterations()
        {
            return this.maximumNumberOfIterations;
        }

    }
}
