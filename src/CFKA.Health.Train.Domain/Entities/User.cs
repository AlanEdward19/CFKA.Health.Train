﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CFKA.Health.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public EUserType UserType { get; set; }

    public Guid? TrainerId { get; set; }

    [ForeignKey(nameof(TrainerId))]
    public virtual User Trainer { get; set; }

    public virtual IEnumerable<Training> Trainings { get; set; }

    public User()
    {
        
    }
}