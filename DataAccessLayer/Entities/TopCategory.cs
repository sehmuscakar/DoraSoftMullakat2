using CoreLayer.Entities;

namespace DataAccessLayer.Entities
{
    public class TopCategory:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Category> Categories { get; set; }
        public List<SubCategoory> SubCategoories { get; set; }


    }
}
