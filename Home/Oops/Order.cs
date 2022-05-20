namespace Home.Oops
{
    class Order
    {
        int Orderid;
        string Date;
        string OName;
        int item;
        public void SetOrderid(int n)
        {
            Orderid = n;
        }
        public int GetO()
        {
            return Orderid;
        }
        public void SetDate(string d)
        {
            Date = d;
        }
        public string GetD()
        {
            return Date;
        }
        public void SetCust(string na)
        {
            OName = na;
        }
        public string GetCust()
        {
            return OName;
        }
        public void Setitem(int no)
        {
            item = no;
        }
        public int Getitem()
        {
            return item;
        }
    }
    class Custmore:Order
    {
        int Custid;
        string CustName;
        string CustAddress;
        public void SetCust(int Cid)
        {
            Custid = Cid;
        }
        public int GetCust()
        {
            return Custid;
        }
        public void SetCustName(string Cna)
        {
            CustName = Cna;
        }
        public string GetName()
        {
            return CustName;
        }
        public void SetCustAddress(string Add)
        {
            CustAddress = Add;
        }
        public string GetAdd()
        {
            return CustAddress;
        }
    }
    class Address:Order
    {
        string Addre;
        string City;
        int Pincode;
        public void SetAdd(string a)
        {
            Addre = a;
        }
        public string GetAdd()
        {
            return Addre;
        }
        public void SetCity(string c)
        {
            City = c;

        }
        public string GetC()
        {
            return City;
        }
        public void SetPin(int p)
        {
            Pincode = p;
        }
        public int GetP()
        {
            return Pincode;
        }

    }
    class Cart
    {
        static void Main(string[] args)
        {
            Order O=new Order();
            
            Order B=new Order();
        }
    }
}
