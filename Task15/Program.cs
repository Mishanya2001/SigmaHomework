using Task15.Models;

namespace Task15
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                TestProblem1();
                Console.WriteLine(new string('-', 20));
                TestProblem2();
                Console.WriteLine(new string('-', 20));
                TestProblem3();
                Console.WriteLine(new string('-', 20));
                TestProblem4();
                Console.WriteLine(new string('-', 20));
                TestProblem5();
                Console.WriteLine(new string('-', 20));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
            Console.ReadLine();
        }
        private static void TestProblem1()
        {
            var naturalNumbers = new int[] { 1, 3, 4, 6, 10 };
            var stringList = new List<string?> { null, "3", "88qq", "w3ng", "1 qq", "qwerty", "9 guys" };
            foreach (var item in LinqExpressions.LinqProblem1(naturalNumbers, stringList))
            {
                Console.WriteLine(item);
            }
        }
        private static void TestProblem2()
        {
            var stringList = new List<string> { "AABSX", "CPZX", "OALL", "ASMLDIN", "Q", "A", "PEORISN", "CCSDSAS", "BSKOELSQWED" };

            foreach (var element in LinqExpressions.LinqProblem2(stringList))
            {
                Console.WriteLine(element);
            }
        }
        private static void TestProblem3()
        {
            var years = new int[] { 2012, 2013, 2020, 2022, 2012, 2021, 2023 };
            var nameList = new List<Applicant>
            {
                new Applicant(10, 2019, "Pavlenko"),
                new Applicant(10, 2020, "Petrenko"),
                new Applicant(11, 2012, "Ohrimenko"),
                new Applicant(12, 2022, "Stasyk"),
                new Applicant(20, 2013, "Ivanov"),
                new Applicant(15, 2021, "Prtrov"),
                new Applicant(11, 2022, "Sidorov"),
                new Applicant(32, 2012, "Trohumenko"),
                new Applicant(17, 2013, "Bortnik"),
                new Applicant(11, 2022, "Oliynuk"),
                new Applicant(11, 2016, "Ciumbaluk"),
                new Applicant(11, 2012, "Ivanenko"),
                new Applicant(17, 2013, "Petrenko"),
                new Applicant(12, 2017, "Popil"),
                new Applicant(28, 2021, "Kroshka"),
                new Applicant(24, 2022, "Styrenko"),
                new Applicant(6, 2012, "Voitenko"),
                new Applicant(8, 2021, "Klumenko"),
                new Applicant(11, 2022, "Klumchuk"),
            };

            foreach (var item in LinqExpressions.LinqProblem3(nameList, years))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        private static void TestProblem4()
        {
            var supplierList = new List<Supplier>
            {
                new Supplier(2002, "qwqwas"),
                new Supplier(2001, "wrewd"),
                new Supplier(1997, "cgvh"),
                new Supplier(1976, "ecdrtfv"),
                new Supplier(1996, "xxrtvybui"),
                new Supplier(1988, "rbgyuhi"),
                new Supplier(1981, "rtfvbgyjim"),
                new Supplier(1945, "lmkjnbhg"),
                new Supplier(1932, "umynfeerf")
            };
            var supplierDiscountList = new List<SupplierDiscount>
            {
                new SupplierDiscount(0, "Shop1", 10m),
                new SupplierDiscount(1, "Shop2", 5m),
                new SupplierDiscount(2, "Shop12", 12m),
                new SupplierDiscount(1, "Shop1", 12m),
                new SupplierDiscount(2, "Shop2", 15m),
                new SupplierDiscount(3, "Shop1", 12m),
                new SupplierDiscount(3, "Shop2", 18m),
                new SupplierDiscount(3, "Shop3", 10m),
                new SupplierDiscount(2, "Shop1", 23m),
                new SupplierDiscount(4, "Shop3", 10m),
                new SupplierDiscount(6, "Shop1", 23m),
                new SupplierDiscount(8, "Shop1", 23m),
                new SupplierDiscount(7, "Shop3", 10m),
                new SupplierDiscount(7, "Shop1", 12m),
                new SupplierDiscount(7, "Shop4", 18m),
            };

            foreach (var item in LinqExpressions.LinqProblem4(supplierList, supplierDiscountList))
            {
                Console.WriteLine(item);
            }
        }
        private static void TestProblem5()
        {
            var nameList = new List<Applicant>
            {
                new Applicant(10, 2019, "Pavlenko"),
                new Applicant(10, 2020, "Petrenko"),
                new Applicant(11, 2012, "Ohrimenko"),
                new Applicant(12, 2022, "Stasyk"),
                new Applicant(20, 2013, "Ivanov"),
                new Applicant(15, 2021, "Prtrov"),
                new Applicant(11, 2022, "Sidorov"),
                new Applicant(32, 2012, "Trohumenko"),
                new Applicant(17, 2013, "Bortnik"),
                new Applicant(11, 2022, "Oliynuk"),
                new Applicant(11, 2016, "Ciumbaluk"),
                new Applicant(11, 2012, "Ivanenko"),
                new Applicant(17, 2013, "Petrenko"),
                new Applicant(12, 2017, "Popil"),
                new Applicant(28, 2021, "Kroshka"),
                new Applicant(24, 2022, "Styrenko"),
                new Applicant(6, 2012, "Voitenko"),
                new Applicant(8, 2021, "Klumenko"),
                new Applicant(11, 2022, "Klumchuk"),
            };

            foreach (var item in LinqExpressions.LinqProblem5(nameList))
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var value in item.Value)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}