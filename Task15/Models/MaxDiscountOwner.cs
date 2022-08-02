namespace Task15.Models
{
    public class MaxDiscountOwner
    {
        public int SupplierID { get; private set; }
        public int YearOfBirth { get; private set; }
        public string Street { get; private set; }
        public string ShopName { get; private set; }
        public decimal Discount { get; private set; }
        public MaxDiscountOwner(int supplierID, int yearOfBirth, string street, string shopName, decimal discount)
        {
            SupplierID = supplierID;
            YearOfBirth = yearOfBirth;
            Street = street;
            ShopName = shopName;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{ShopName} - {SupplierID}; {YearOfBirth}; {Street}; {Discount}%";
        }
    }
}
