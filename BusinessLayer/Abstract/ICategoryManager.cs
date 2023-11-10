using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface ICategoryManager
    {
        List<CategoryListDto> GetcCategoryListManager();
        List<Category> GetCategoryByFilterManager(string Name , decimal? Price , string isActive);
        List<Category> GetList();
        void Add(Category category);
        void Update(Category category);
        void Remove(Category category);
        Category GetByID(int id);

    }
}
