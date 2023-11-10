using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class CategoryDal : BaseRepository<Category, ProjeContext>, ICategoryDal
    {
        public List<Category> GetCategroyByFilterDal(string Name, decimal? Price, string isActive) // burdaki paremetreler controlerdaki ve view deki isimler ile aynı olmalı 
        {
            using (var context = new ProjeContext())
            {
                IQueryable<Category> categories = context.Categories;


                if (Name!=null)
                {

             categories=categories.Where(i=>i.Name.ToLower().Contains(Name.ToLower()));//Contains bu fonksiyon;Belirtilen karşılaştırma kurallarını kullanarak belirtilen karakterin bu dize içinde olup olmadığını belirten bir değer döndürür.
                }

                if (Price !=null)
                {
                    categories = categories.Where(i => i.Price >= Price); // girilen tutardan eşit ve fazla olanları getir
                }

                if (isActive != "on")
                {
                    categories = categories.Where(i => i.isActive == true);
                }


                //categories.Select(categori => new Category()
                //{
                //    Id = categori.Id,

                //    ImageUrl = categori.ImageUrl,
                //});


                return categories.ToList();
            }
        }

        public List<CategoryListDto> GetCtegoryListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Categories.Select(category => new CategoryListDto()
                {
                    Id = category.Id,
                  ImageUrl= category.ImageUrl,
                  Name= category.Name,
                  Price = category.Price,
                  isActive= category.isActive,
                  TopCattegoryName=category.TopCattegory.Name,
                // SubCategoryId=category.SubCategoories
                
             
                });
                return a.ToList();
            }
        }
    }
}
