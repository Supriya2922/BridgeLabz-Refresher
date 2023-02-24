using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Stock
    {
        public String StockName { get; set; }
        public double SharePrice { get; set; }
        public int ShareNumber { get; set; }
        public double totalval;
        public double totVal()
        {
            this.totalval = SharePrice * ShareNumber;
            return totalval;
        }
        public String report()
        {
            String str = $"Stock Name :{StockName} \nShare Price: {SharePrice} \nNumber of Shares :{ShareNumber}\nTotal value:{totalval}";
            return str;
        }
    }
}
