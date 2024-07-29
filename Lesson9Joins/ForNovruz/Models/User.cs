namespace ForNovruz.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public byte[] Password { get; set; }
    public byte[] Salt { get; set; }

}
