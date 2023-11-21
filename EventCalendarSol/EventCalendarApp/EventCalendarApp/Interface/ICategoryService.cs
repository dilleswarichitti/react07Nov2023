using EventCalendarApp.Models;

namespace EventCalendarApp.Interface
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category Add(Category category);
       // Category Remove(Category category);
        //Category Update(Category category);

    }
}
