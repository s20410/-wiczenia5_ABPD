using ABPD5.Models;
using ABPD5.Repositories.Interfaces;

namespace ABPD5.Repositories.Implementation;

public class ClientHandler : IClientHandler
{
    private readonly TripDbContext _context;

    public ClientHandler(TripDbContext context)
    {
        _context = context;
    }

    public async Task<bool> DeleteClient(int idClient)
    {
        var client = await _context.Clients.SingleOrDefaultAsync(x => x.IdClient == idClient);
        var result = await (from ct in _context.ClientTrips where ct.IdClient == idClient select ct).ToListAsync();
        if (client == null)
        {
            return false;
        }

        if (result.Count == 0)
        {
            _context.Remove(client);

        }
        
        return await _context.SaveChangesAsync() > 0;
    }
}