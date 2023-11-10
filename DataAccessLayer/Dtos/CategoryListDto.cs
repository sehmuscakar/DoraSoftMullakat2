using DataAccessLayer.Entities;

namespace DataAccessLayer.Dtos
{
    public class CategoryListDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool isActive { get; set; }
        public string TopCattegoryName { get; set; }

    //    public int SubCategoryId { get; set; } // getbyıd işleminde kullanmak için detaya gidecek ya bu id ye göre gidecek

    //    public List<SubCategoory> subCategoories { get; set; }
    }
}
