using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Lion : Animal
    {
        private int numberOfClaws;

        public void SetNumberOfClaws(int numberOfClaws)
        {
            this.numberOfClaws = numberOfClaws;
        }

        public new void Describe()
        {
            Console.WriteLine(this.name + " " + this.type + " " + this.numberOfClaws + " claws");
        }
        
    }
}
