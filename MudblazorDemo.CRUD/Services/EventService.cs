using MudblazorDemo.CRUD.Data;
using MudblazorDemo.CRUD.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudblazorDemo.CRUD.Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _dbContext;

        public EventService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public void DeleteEvent(int id)
        {
            var customer = _dbContext.Events.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _dbContext.Events.Remove(customer);
                _dbContext.SaveChanges();
            }
        }

        public Event GetEventById(int id)
        {
            var customer = _dbContext.Events.SingleOrDefault(x => x.Id == id);
            return customer;
        }

        public List<Event> GetEvents()
        {
            return _dbContext.Events.ToList();
        }

        public void SaveEvent(Event ev)
        {
            if (ev.Id == 0) _dbContext.Events.Add(ev);
            else _dbContext.Events.Update(ev);
            _dbContext.SaveChanges();
        }

        public void UpdateEvent(Event ev)
        {
            _dbContext.Events.Update(ev);
            _dbContext.SaveChanges();
        }
    }
}
