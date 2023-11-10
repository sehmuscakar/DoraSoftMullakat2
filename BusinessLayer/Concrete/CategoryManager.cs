using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(id);
        }

        public List<Category> GetCategoryByFilterManager(string Name, decimal? Price , string isActive )
        {
            return _categoryDal.GetCategroyByFilterDal(Name,Price,isActive);
        }

        public List<CategoryListDto> GetcCategoryListManager()
        {
            return _categoryDal.GetCtegoryListDal();
        }

        public List<Category> GetList()
        {
           return _categoryDal.GetAll();
        }

        public void Remove(Category category)
        {
           _categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
           _categoryDal.Update(category);
        }
    }
}
