using EventCalendarApp.Exceptions;
using EventCalendarApp.Services;
using EventCalendarApp.Interfaces;
using EventCalendarApp.Models;
using EventCalendarApp.Repositories;

namespace EventCalendarApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<int, Category> _categoryRepository;

        public CategoryService(IRepository<int, Category> repository)
        {
            _categoryRepository = repository;
        }
        public Category Add(Category category)
        {
            var result = _categoryRepository.Add(category);
            return result;
        }
        public List<Category> GetCategories()
        {
            var category = _categoryRepository.GetAll();
            if (category != null)
            {
                return category.ToList();
            }
            throw new NocategoriesAvailableException();
        }
        /*public Category Remove(Category category)
        {
            var CategoryId = _categoryRepository.GetAll().FirstOrDefault(c => c.id == category.id);
            if (CategoryId != null)
        {
            var result = _categoryRepository.Delete(CategoryId.id);
            if (result != null) return result;
        }
        return CategoryId;
        }
        public Category Update(Category category)
        {
            var CategoryId = _categoryRepository.GetAll().FirstOrDefault(c => c.id == category.id);
            if (CategoryId != null)
        {
            var result = _categoryRepository.Update(category);
            if (result != null) return result;
        }
        return CategoryId;
        }*/
    }
}
