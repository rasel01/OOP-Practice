using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public class StackClass
    {
        List<object> objects = new List<object>();
        public void Push(object obj)
        {
            objects.Add(obj);

        }

        public object Pop()
        {
           object obj = objects.LastOrDefault();
           return obj;
        }

        public void Clear()
        {
            objects.Clear();
        }

    }
}
