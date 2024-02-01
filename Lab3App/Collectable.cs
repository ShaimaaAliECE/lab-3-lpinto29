using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;
       
        public virtual void Display() { }

        public virtual void AddMe(List <Collectable> collection) 
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }


    }
}
