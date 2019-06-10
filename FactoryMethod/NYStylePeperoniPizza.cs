using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class NYStylePeperoniPizza : Pizza
    {
        public override string Bake()
        {
            return " ,Bake NYStylePeperoniPizza"; 
        }

        public override string Box()
        {
            return " ,Box NYStylePeperoniPizza";
        }

        public override string Cut()
        {
            return " ,cut NYStylePeperoniPizza";

        }

        public override string Prepare()
        {
            return " ,Prepare NYStylePeperoniPizza";
        }
    }
}
