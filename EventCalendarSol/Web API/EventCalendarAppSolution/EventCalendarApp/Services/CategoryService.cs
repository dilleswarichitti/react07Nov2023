//using EventCalendarApp.Exceptions;
//using EventCalendarApp.Models;
//using EventCalendarApp.Repositories;
//using Microsoft.EntityFrameworkCore;
//using EventCalendarApp.Context;
//using EventCalendarApp.Interfaces;

//namespace EventCalendarApp.Services
//{
//    public class CategoryService : ICategoryService
//    {
//        private readonly IRepository<string, Category> _categoryRepository;
//        //private readonly CalendarContext _context;
//        public CategoryService(IRepository<string, Category> repository)
//        {
//            _categoryRepository = repository;
//            // _context = context;
//        }
//        ///// <summary>
//        ///// adding the category to database
//        ///// </summary>
//        ///// <param name="category">category to be added</param>
//        ///// <returns>added category</returns>
//        ///// <exception cref="IdAlreadyExist"></exception>
//        //public Category Add(Category category)
//        //{
//        //    if (iscategoryidunique(category.id))
//        //    {
//        //        return _categoryRepository.Add(category);
//        //    }
//        //    throw new IdAlreadyExist();
//        //}
//        ///// <summary>
//        ///// it checks whether the category is unique or not
//        ///// </summary>
//        ///// <param name="categoryId">get category by id</param>
//        ///// <returns>all categories</returns>
//        //private bool iscategoryidunique(int categoryid)
//        //{
//        //    return !_categoryRepository.GetAll().Any(c => c.id == categoryid);
//        //}
//        /// <summary>
//        /// getting the list of categories
//        /// </summary>
//        /// <returns>returns categories to the list</returns>
//        /// <exception cref="NocategoriesAvailableException"></exception>
//        public List<Category> GetCategories()
//        {
//            var category = _categoryRepository.GetAll();
//            if (category != null)
//            {
//                return category.ToList();
//            }
//            throw new NocategoriesAvailableException();
//        }
//        //public void AddEventToCategory(int categoryId, Event events)
//        //{
//        //    var existingCategory = _context.Categories.Include(c => c.Events)
//        //        .FirstOrDefault(c => c.Events.Any(e => e.Id == events.Id));

//        //    if (existingCategory == null)
//        //    {
//        //        var category = _context.Categories.Include(c => c.Events).FirstOrDefault(c => c.id == categoryId);

//        //        if (category != null)
//        //        {
//        //            // Ensure the event is not associated with any other category
//        //            events.CategoryId = categoryId; // Set the category directly
//        //            _context.SaveChanges();
//        //        }
//        //    }
//        //}

//        /*public Category Remove(Category category)
//        {
//            var CategoryId = _categoryRepository.GetAll().FirstOrDefault(c => c.id == category.id);
//            if (CategoryId != null)
//        {
//            var result = _categoryRepository.Delete(CategoryId.id);
//            if (result != null) return result;
//        }
//        return CategoryId;
//        }
//        public Category Update(Category category)
//        {
//            var CategoryId = _categoryRepository.GetAll().FirstOrDefault(c => c.id == category.id);
//            if (CategoryId != null)
//        {
//            var result = _categoryRepository.Update(category);
//            if (result != null) return result;
//        }
//        return CategoryId;
//        }*/
//        public Category Add(Category category)
//        {
//            var result = _categoryRepository.Add(category);
//            return result;
//        }
//    }
//}