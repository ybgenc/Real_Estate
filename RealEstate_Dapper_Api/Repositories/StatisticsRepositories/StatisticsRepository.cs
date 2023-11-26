using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Repositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepository
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context  _context;
        public StatisticsRepository(Context context)
        {
            _context = context;
        }
        public  int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Category where CategoryStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values =  connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Employee where Status=1";
            using(var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            string query = "Select Count(*) From Product where ProductCategory = 2";
            using (var  connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AverageProductByRent()
        {
            string query = "Select Avg(ProductPrice) From Product where Type='RENT'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal AverageProductBySale()
        {
            string query = "Select Avg(ProductPrice) From Product where Type='SALE'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public int AverageRoomCount()
        {
            string query = "Select Avg(RoomCount) From productDetails";
            using (var  context = _context.CreateConnection())
            {
                var values = context.QueryFirstOrDefault<int>(query);
                return values;
            }

        }

        public int CategoryCount()
        {
            string query = "Select Count(CategoryName) From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "Select top(1) CategoryName,Count(*) from Product inner join Category on Product.ProductCategory = Category.CategoryID Group by CategoryName order by Count(*) Desc";
            using(var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string CityNameByMaxProductCount()
        {
            string query = "Select top(1) ProductCity, Count(*) from product group by ProductCity order by Count(*) Desc";
            using (var connection = _context.CreateConnection())
            {

                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int DifferentCountryCount()
        {
            string query = "Select Count(Distinct(ProductCity)) From Product";
            using(var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "Select Name,Count(*) From Product Inner join Employee On Product.EmployeeID = Employee.EmployeeID Group By Name Order By Count(*) Desc";
            using(var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public decimal LastProductPrice()
        {
            string query = "Select Top 1 ProductPrice From Product where Type like '%SALE%' Order By ProductID Desc";
            using(var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal LastProductRentPrice()
        {
            string query = "Select top 1 ProductPrice from Product where Type like '%RENT%' order by ProductID desc";
            using(var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "Select top 1 BuildYear From ProductDetails Order by BuildYear desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string OldestBuildingYear()
        {
            string query = "Select distinct BuildYear From ProductDetails Order by BuildYear asc offset 1 ROWS fetch next 1 row only";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int PassiveCategoryCount()
        {
            string query = " Select Count(*) From Category where CategoryStatus  = '0'";
            using (var  connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCount()
        {
            string query = "Select count (*) from Product";
            using(var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }
    }
}
