namespace my_architecture__level_2020.Domain.Core.Basket
{
    using System.Collections.Generic;

    public class Basket
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public IEnumerable<int> ProductIds { get; set; }
    }
}