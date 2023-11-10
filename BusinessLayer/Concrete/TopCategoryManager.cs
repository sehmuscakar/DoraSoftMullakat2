using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class TopCategoryManager : ITopCategoryManager
    {
        private readonly ITopCategoryDal _topCategoryDal;

        public TopCategoryManager(ITopCategoryDal topCategoryDal)
        {
            _topCategoryDal = topCategoryDal;
        }

        public void Add(TopCategory topCategory)
        {
           _topCategoryDal.Add(topCategory);
        }

        public TopCategory GetByID(int id)
        {
            return _topCategoryDal.Get(id);
        }

        public List<TopCategory> GetList()
        {
           return _topCategoryDal.GetAll();
        }

        public void Remove(TopCategory topCategory)
        {
            _topCategoryDal.Delete(topCategory);
        }

        public void Update(TopCategory topCategory)
        {
           _topCategoryDal.Update(topCategory); 
        }
    }
}
