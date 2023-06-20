using System.ComponentModel.DataAnnotations;

namespace CFKA.Health.Domain.Entities;

public class TrainingExercise
{
    [Key]
    public int Id { get; private set; }
    public int Sets { get; private set; }
    public int Reps { get; private set; }
    public string Observations { get; private set; }

    public virtual Training Training { get; private set; }
    public virtual Exercise Exercise { get; private set; }

    public TrainingExercise(int sets, int reps, string observations)
    {
        Sets = sets;
        Reps = reps;
        Observations = observations;
    }

    public void SetExercise(Exercise exercise) => Exercise = exercise;
}