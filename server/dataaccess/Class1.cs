namespace dataaccess;

public class Pet
{
    public string Name { get; set; }
}

public class MyPetDataAccess
{
    public List<Pet> GetAllMyPets()
    {
        return new List<Pet>()
        {
            new Pet()
            {
                Name = "Bob"
            }
        };
    }

}
