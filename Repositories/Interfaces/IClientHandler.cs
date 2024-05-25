namespace ABPD5.Repositories.Interfaces;

public interface IClientHandler
{
    public Task<bool> DeleteClient (int idClient);
}