namespace my_architecture__level_2020.HttpApi.Controllers
{
    using Infrastructure.Data.UnitOfWork;
    using BaseController = Microsoft.AspNetCore.Mvc.ControllerBase;

    public class ControllerBase : BaseController
    {
        public ControllerBase(
            IUnitOfWork unitOfWork
        )
        {
            this.unitOfWork = unitOfWork;
        }

        private IUnitOfWork unitOfWork { get; }
    }
}