using System.Text.Json.Serialization;

namespace UniversitaryApiSqlServer.Models;

public class Curso
{
    public int CursoId { get; set; }
    public string Nombre { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Asignacion> Asignaciones { get; set; } = new List<Asignacion>();
}
