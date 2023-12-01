namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class ResultProductDto
    {
            public int productId { get; set; }
            public string productTitle { get; set; }
            public decimal productPrice { get; set; }
            public string productCity { get; set; }
            public string productDistrict { get; set; }
            public string categoryName { get; set; }
            public string productCoverImage { get; set; }
            public string type { get; set; }
            public string productAddress { get; set; }
            public bool dealOfTheDay { get; set; }

    }
}
