using System.Text.Json;
using System.Text.Json.Nodes;
using dataaccess;

var myInstance = new MyPetDataAccess().GetAllMyPets();

var myTextualRepresentation = JsonSerializer.Serialize(myInstance);
Console.WriteLine(myTextualRepresentation);