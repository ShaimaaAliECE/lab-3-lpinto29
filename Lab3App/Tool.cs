using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Tool : Collectable
    {
        public override void AddMe(List <Collectable> collection)
        {
            base.AddMe(collection);
            DoAction();
        }

        public virtual void DoAction() { }
    }
}
