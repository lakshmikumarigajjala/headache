using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    interface IStockItem
    {
        string partNumber { get; set; }
        string PartName { get; set; }
        decimal UnitPrice { get; set; }
    }
    public class Part: IStockItem
    {
        private string ID;
        protected  string name;
        protected decimal price;
        private int qty;
        public string PartNumber
        {
            get { return ID; }
            set { ID = value; }
        }
        public string PartName
        {
            get { return name; }
            set { name = value; }
        }
        public decimal UnitPrice
        {
            get { return (price < 0) ? 0.0M : price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return (qty < 0) ? 0 : qty; }
            set { qty = value; }
        }

        public string partNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public string partNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Part()
        {                                                                                                     
            this.ID = null;
            this.name = "unknown";
            this.qty = 0;
            this.price = 0.0M;
        }
        public Part(string Nbr,string nm,int q,decimal pr)
        {
            this.ID = Nbr;
            this.name = nm;
            this.qty = q;
            this.price = pr;
        }
    }
}
