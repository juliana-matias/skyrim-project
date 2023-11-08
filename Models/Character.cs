public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "Dovahkiin";
    public int HitPoints { get; set; } = 100;
    public int Strength { get; set; } = 10;
    public int Defense { get; set; } = 10;
    public int Intelligence { get; set; } = 10;
    public RpgClass Class { get; set; } = RpgClass.Nord;

    //adding properties to the models to create the relationship between tables
    //a user can have a list of characters, but the character belongs to one user
    public User? User { get; set; }
}