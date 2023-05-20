using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFKA.Health.Domain.Entities;

public class Exercise
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int MuscleId { get; set; }

    [ForeignKey(nameof(MuscleId))]
    public virtual Muscle Muscle { get; set; }
}