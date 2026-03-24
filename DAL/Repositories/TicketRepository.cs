using ZooManagement.DAL.Data;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;

namespace ZooManagement.DAL.Repositories
{
    public class TicketReposity : ITicketRepository
    {
        private readonly ZooDbContext _context;

        public TicketReposity(ZooDbContext context)
        {
            _context = context;
        }
        public void Add(int visitorId, int attractionId)
        {
            var ticket = new Ticket
            {
                Status = true,
                AttractionId = attractionId,
                VisitorId = visitorId
            };
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }    
    }
}