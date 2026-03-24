using System;

namespace ZooManagement.DAL.Interfaces
{
    public interface ITicketRepository
    {
        void Add(int visitorId, int attractionId);
    }
}