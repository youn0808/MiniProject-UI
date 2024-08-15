using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models.Blog
{
    /*Item can be any type and object.*/
    public class PagedResults<T> 
    {
        public IEnumerable<T> Items { get; set; }//Offset fetch
        public int TotalCount { get; set; } //This is what we get back. when we passing in 

    }
}
