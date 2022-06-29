using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzBot.Classes.AmazonProductPage
{
    public class AddDataGrid
    {
        public void Execute(List<object> list)
        {
            list.Insert(3, "99.9");
            //new FindedItems(list);
            
        }
        
    }
}
