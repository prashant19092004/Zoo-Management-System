
using ZooManagement.BAL.Interfaces;
using ZooManagement.DAL.Interfaces;

namespace ZooManagement.BAL.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _repository;
        public TicketService(ITicketRepository repository)
        {
            _repository = repository;
        }
        public void BuyTicket(int visitorId, int attractionId)
        {
            _repository.Add(visitorId, attractionId);
        }
    }
}