using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Product : IProduct
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
    }
}
