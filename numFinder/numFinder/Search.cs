using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace numFinder
{
    public class Search
    {
        private string name;
        private double firstValueToBeTested;
        private int numberOfIteration;
        private BlackBox BB;
        private double valueFound;
        public Search(BlackBox BB,string name,double FirstValueToBeTested)
        {
            this.name = name;
            this.BB = BB;
            this.firstValueToBeTested=FirstValueToBeTested;
            this.numberOfIteration = 0;
            

        }

        public void setValueFound(double num)
        {
            this.valueFound = num;
        }

        public double getValueFound()
        {
            return this.valueFound;
        }
        public void setNumberOfIteration (int num)
        {
            this.numberOfIteration = num;
        }
        public int getNumberOfIteration()
        {
            return this.numberOfIteration;
        }
        public BlackBox getBlackBox()
        {
            return this.BB;
        }
        public void setBlackBox(BlackBox BB)
        {
            this.BB = BB;
        }
        public void setFirstValueToBeTested(double num)
        {
            this.firstValueToBeTested = num;
        }
        public double getFirstValueToBeTested()
        {
            return this.firstValueToBeTested;
        }

        public bool iterationControl()
        {
            return (this.numberOfIteration >= this.BB.getMaximumNumberOfIterations())?true:false;
        }
        public void printResult()
        {
            Console.WriteLine("I am : {0} ", this.name);
            Console.WriteLine("I found : {0} , with {1} iteration", this.valueFound, this.numberOfIteration);
            if (iterationControl())
                Console.WriteLine("Probably i didn't find the correct value because i exceeded the maximum number of iteration allowed");
            
        }
    }
}
