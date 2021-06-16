namespace my_architecture__level_2020.HttpApi.Models.Primitive.Paging
{
    using System.ComponentModel.DataAnnotations;

    public class PagingRequest
    {
        [Required] public int Page { get; set; }

        [Required] public int Take { get; set; }
    }
}