using EventCalendarApp.Context;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EventCalendarApp.Repositories
{
    public class CategoryRepository : IRepository<int, Category>
    {
        private readonly CalendarContext _context;

        public CategoryRepository(CalendarContext context)
        {
            _context = context;
        }

        public Category Add(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Category Delete(int key)
        {
            var category = GetById(key);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return category;
            }
            return null;
        }

        public IList<Category> GetAll()
        {
            if (_context.Categories.Count() == 0)
                return null;
            return _context.Categories.ToList();
        }

        public Category GetById(int key)
        {
            var category = _context.Categories.SingleOrDefault(c => c.id== key);
            return category;
        }

        public Category Update(Category entity)
        {
            var category = GetById(entity.id);
            if (category != null)
            {
                _context.Entry<Category>(category).State = EntityState.Modified;
                _context.SaveChanges();
                return category;
            }
            return null;
        }
    }
}