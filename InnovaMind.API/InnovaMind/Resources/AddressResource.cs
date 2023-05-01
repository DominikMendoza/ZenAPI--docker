using InnovaMind.API.Security.Domain.Models;

namespace InnovaMind.API.InnovaMind.Resources;
public class AddressResource
{
    public int Id { get; set; }
    public string NameAddress { get; set; }
    public User User { get; set; }
}