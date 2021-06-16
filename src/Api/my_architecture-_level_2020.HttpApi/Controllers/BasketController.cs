namespace my_architecture__level_2020.HttpApi.Controllers
{
    using System.Threading.Tasks;
    using Infrastructure.Data.UnitOfWork;
    using Microsoft.AspNetCore.Mvc;
    using Models.Basket.GetAllBasket;

    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        public BasketController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        
        [HttpGet]
        public async Task<GetAllBasketResponse> Get(
            [FromQuery] GetAllBasketRequest request
        )
        {
            return new GetAllBasketResponse();
        }
    }
}