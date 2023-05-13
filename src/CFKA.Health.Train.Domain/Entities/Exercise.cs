using System.ComponentModel.DataAnnotations;

namespace CFKA.Health.Domain.Entities;

public class Exercise
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public Muscle Muscle { get; set; }
}