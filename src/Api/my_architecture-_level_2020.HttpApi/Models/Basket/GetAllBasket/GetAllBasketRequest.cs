namespace my_architecture__level_2020.HttpApi.Models.Basket.GetAllBasket
{
    using System.ComponentModel.DataAnnotations;
    using Primitive.Paging;

    public class GetAllBasketRequest
    {
        public PagingRequest Paging { get; set; }
    }
}