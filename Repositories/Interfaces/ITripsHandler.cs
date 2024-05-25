using ABPD5.DTO.Requests;

namespace ABPD5.Repositories.Interfaces;

public abstract class ITripsHandler
{
    public abstract Task<ICollection<TripsDTO>> GetTripsAsync ();

    public abstract Task<bool> UpdateClients (ClientDTO clients);
}