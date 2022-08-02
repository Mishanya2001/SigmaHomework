namespace Task15.Models
{
    public class SupplierDiscount
    {
        public int SupplierID { get; private set; }
        public string ShopName { get; private set; }
        public decimal Discount { get; private set; }
        public SupplierDiscount(int supplierID, string shopName, decimal discount)
        {
            SupplierID = supplierID;
            ShopName = shopName;
            Discount = discount;
        }
    }
}
