namespace Task15.Models
{
    public class Supplier
    {
        private static int IdSelector = 0;
        public int SupplierID { get; private set; }
        public int YearOfBirth { get; private set; }
        public string Street { get; private set; }
        public Supplier(int yearOfBirth, string street)
        {
            SupplierID = IdSelector++;
            YearOfBirth = yearOfBirth;
            Street = street;
        }
        public override string ToString()
        {
            return $"Supplier ID: {SupplierID}; Year of birth: {YearOfBirth}; Street: {Street}";
        }
    }
}
