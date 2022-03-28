using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWPF_14
{
    public enum ProductCategories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ProductCategories ProductCategory { get; set; }
    }
}
