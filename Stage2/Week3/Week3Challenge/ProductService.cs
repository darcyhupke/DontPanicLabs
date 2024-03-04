using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Challenge
{
    public class ProductService
    {
        private readonly ICrochet _crochet;

        public ProductService(ICrochet aCrochet)
        {
            _crochet = aCrochet;
        }

        public void GetPricing(float materialAmount)
        {
            _crochet.GetPricing(materialAmount);
        }
    }
}