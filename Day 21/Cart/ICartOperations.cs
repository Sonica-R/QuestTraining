using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    public interface ICartOperations
    {
        void AddItems();
        void Update();
        void Delete();
    }
}
