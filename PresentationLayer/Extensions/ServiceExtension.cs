using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace PresentationLayer.Extensions
{
    public static class ServiceExtension
    {
        public static void MyconfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IMenuManager, MenuManager>();
            services.AddScoped<IMenuDal, MenuDal>();
            services.AddScoped<ISubMenuManager, SubMenuManager>();
            services.AddScoped<ISubMenuDal, SubMenuDal>();

            services.AddScoped<IHomeMenuManager, HomeMenuManager>();
            services.AddScoped<IHomeMenuDal, HomeMenuDal>();


            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ICategoryDal, CategoryDal>();

            services.AddScoped<ITopCategoryManager, TopCategoryManager>();
            services.AddScoped<ITopCategoryDal, TopCategoryDal>();

            services.AddScoped<ISubCategoryManager, SubCategoryManager>();
            services.AddScoped<ISubCategoryDal, SubCategoryDal>();

            services.AddScoped<IContactCompanyManager, ContactCompanyManager>();
            services.AddScoped<IContactCompanyDal, ContactCompanyDal>();

        }
    }
}
