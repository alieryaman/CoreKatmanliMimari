using CoreKatmanliMimari.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKatmanliMimari.WEBUI.Models
{
    public class CategoryViewModel
    {

        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
