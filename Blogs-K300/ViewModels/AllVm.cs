using Blogs_K300.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogs_K300.ViewModels
{
    public class AllVm
    {
        public IList<Category> CategoryList { get; set; }
        public IList<Product> Product{ get; set; }


    }
}