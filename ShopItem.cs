using System;

namespace Game
{
    public class ShopItem
    {
        public int id;
        public string sname;
        public int price;
        public int stock;
        public string info;

        public ShopItem(int price, string sname, Random rnd, int id, string info)
        {
            this.price = price;
            this.sname = sname;
            this.id = id;
            this.stock = rnd.Next(1, 5);
            this.info = info;
        }
    }
}
