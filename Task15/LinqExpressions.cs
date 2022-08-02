using System.Text.RegularExpressions;
using Task15.Models;

namespace Task15
{
    public static class LinqExpressions
    {
        public static IEnumerable<string> LinqProblem1(IEnumerable<int> naturalNumbers, IEnumerable<string?> stringList)
        {
            return naturalNumbers
                   .Select(number =>
                       stringList
                           .Where(line => line?.Length == number &&
                                          Regex.IsMatch(line, @"^\d"))
                           .FirstOrDefault() ?? "Не знайдено");
        }
        public static IEnumerable<string> LinqProblem2(IEnumerable<string> stringList)
        {
            return stringList
                .GroupBy(line => line[0])
                .Select(group => new { Symbol = group.Key, Sum = group.Sum(line => line.Length) })
                .OrderByDescending(element => element.Sum)
                .ThenBy(element => (int)element.Symbol)
                .Select(element => $"{element.Symbol}-{element.Sum}");
        }
        public static Dictionary<int, int> LinqProblem3(IEnumerable<Applicant> nameList, IEnumerable<int> years)
        {
            return years.Distinct()
                        .GroupJoin(nameList,
                                   year => year,
                                   applicant => applicant.AdmissionYear,
                                   (year, applicants) =>
                                        new
                                        {
                                            Year = year,
                                            NumberOfSchools = applicants.DistinctBy(applicant => applicant.SchoolNumber).Count()
                                        })
                        .OrderBy(element => element.NumberOfSchools)
                        .ThenBy(element => element.Year)
                        .ToDictionary(element => element.Year, element => element.NumberOfSchools);
        }
        public static IEnumerable<MaxDiscountOwner> LinqProblem4(IEnumerable<Supplier> supplierList,
            IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            return supplierDiscountList
                .Join(
                    supplierList,
                    discount => discount.SupplierID,
                    supplier => supplier.SupplierID,
                    (discount, supplier) =>
                    new MaxDiscountOwner
                    (
                        supplier.SupplierID,
                        supplier.YearOfBirth,
                        supplier.Street,
                        discount.ShopName,
                        discount.Discount)
                    )
                .GroupBy(element => element.ShopName)
                .Select(element => element
                        .OrderByDescending(joinedElement => joinedElement.Discount)
                        .ThenBy(joinedElement => joinedElement.SupplierID)
                        .First())
                .OrderBy(owner => owner.ShopName);
        }
        public static Dictionary<int, IEnumerable<string>> LinqProblem5(IEnumerable<Applicant> applicants)
        {
            return applicants
                   .GroupBy(applicant => applicant.AdmissionYear, applicant => applicant.Surname)
                   .ToDictionary(group => group.Key, group => group.Select(el => el));
        }
    }
}
