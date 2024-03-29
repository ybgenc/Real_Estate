﻿namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository 
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AverageProductBySale();
        decimal AverageProductByRent();
        string CityNameByMaxProductCount();
        int DifferentCountryCount();
        decimal LastProductPrice();
        decimal LastProductRentPrice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int AverageRoomCount();
        int ActiveEmployeeCount();


    }
}
