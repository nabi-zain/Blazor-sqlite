using MudblazorDemo.CRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudblazorDemo.CRUD.Services
{
    public interface IEventService
    {
        List<Event> GetEvents();
        Event GetEventById(int id);
        void SaveEvent(Event customer);
        void DeleteEvent(int id);
        void UpdateEvent(Event ev);
    }
}
