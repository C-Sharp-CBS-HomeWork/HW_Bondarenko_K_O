using System;
using System.Collections.Generic;
using System.Text;

namespace Task_17_4
{
    class Article
    {
        private string name = "";
        private string storName = "";
        private int price;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string StorName
        {
            get
            {
                return storName;
            }

            set
            {
                storName = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
