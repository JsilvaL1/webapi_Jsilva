using System.Text.Json.Serialization;

namespace UniversitaryApiSqlServer.Models;

public class Docente
{
    public int DocenteId { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Asignacion> Asignaciones { get; set; } = new List<Asignacion>();
}
