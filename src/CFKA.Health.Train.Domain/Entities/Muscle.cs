﻿using System.ComponentModel.DataAnnotations;

namespace CFKA.Health.Domain.Entities;

public class Muscle
{
    [Key]
    public int Id { get; set; }
    public EMuscle MainMuscle { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<Exercise> Exercises { get; set; }
}