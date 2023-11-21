//using EventCalendarApp.Exceptions;
//using EventCalendarApp.Interfaces;
//using EventCalendarApp.Models;
//using EventCalendarApp.Repositories;
//using Microsoft.Extensions.Logging;
//using System.Linq.Expressions;

//namespace EventCalendarApp.Services
//{
//    public class NotificationService : INotificationService
//    {

//        private readonly INotificationRepository<int, Notification> _notificationRepository;

//        public NotificationService(INotificationRepository<int, Notification> repository)
//        {
//            _notificationRepository = repository;
//        }

//        public Notification SendNotification(Notification notification)
//        {
//            notification.NotificationDateTime = DateTime.Now;
//            return _notificationRepository.Add(notification);
//        }
//        public IList<Notification> GetNotificationsByUser(string email)
//        {
//            return _notificationRepository.GetAll(n => n.Email == email);


//        }
//    }
//}