using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Animal
    {
        protected String name;
        protected String type;

        private String word;

        public void Talk()
        {
            Console.WriteLine(this.word);
        }

        public void SetWord(String word)
        {
            this.word = word;
        }

        public void SetType(String type)
        {
            this.type = type;
        }

        public void SetName(String name)
        {
            this.name = name;
        } 

        public void Describe()
        {
            Console.WriteLine(this.name + " " + this.type);
        }
    }
}
