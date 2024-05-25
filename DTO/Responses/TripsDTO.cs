using ABPD5.Controllers;

namespace ABPD5.DTO.Requests;

public class TripsDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public int MaxPeople { get; set; }
    public HashSet<ClientDTO> Clients { get; set; }
    public HashSet<CountriesDTO> Countries { get; set; }
}