using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    class Price
    {
        private int price = 100;

        public virtual int GetPrice()
        {
            return price;
        }
    }


    class DecoratorA: Price
    {
        Price _Price;

        public DecoratorA(Price price)
        {
            _Price = price;
        }

        public override int GetPrice()
        {
            return 20 + _Price.GetPrice();
        }
    }

    class DecoratorB: Price
    {
        Price _Price;

        public DecoratorB(Price price)
        {
            _Price = price;
        }

        public override int GetPrice()
        {
            return 30 + _Price.GetPrice();
        }
    }
}

