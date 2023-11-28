//using EventCalendarApp.Exceptions;
//using EventCalendarApp.Models;
//using EventCalendarApp.Repositories;
//using Microsoft.EntityFrameworkCore;
//using EventCalendarApp.Context;
//using EventCalendarApp.Interfaces;

//namespace EventCalendarApp.Services
//{
//    public class ReminderService : IReminderService
//    {
//        private readonly INotificationRepository<int, Reminder> _reminderRepository;
//        public ReminderService(INotificationRepository<int, Reminder> repository)
//        {
//            _reminderRepository = repository;
//        }
//        public Reminder Add(Reminder reminder)
//        {
//            var result = _reminderRepository.Add(reminder);
//            return result;
//        }
//        public List<Reminder> GetReminders()
//        {
//            var reminder = _reminderRepository.GetAll();
//            if (reminder != null)
//            {
//                return reminder.ToList();
//            }
//            throw new RemaindersAreNotAvailableException();
//        }

//        /*public Reminder Remove(Reminder reminder)
//        {
//            var CategoryId = _reminderRepository.GetAll().FirstOrDefault(c => c.id == reminder.id);
//            if (CategoryId != null)
//        {
//            var result = _reminderRepository.Delete(CategoryId.id);
//            if (result != null) return result;
//        }
//        return CategoryId;
//        }
//        public Reminder Update(Reminder reminder)
//        {
//            var CategoryId = _reminderRepository.GetAll().FirstOrDefault(c => c.id == category.id);
//            if (CategoryId != null)
//        {
//            var result = _reminderRepository.Update(reminder);
//            if (result != null) return result;
//        }
//        return CategoryId;
//        }*/
//    }
//}