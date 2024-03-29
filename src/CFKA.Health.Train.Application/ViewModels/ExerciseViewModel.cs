﻿namespace CFKA.Health.Train.Application.ViewModels;

public record ExerciseViewModel
{
    public string Name { get; private set; }
    public MuscleViewModel Muscle { get; private set; }
    public string Url { get; set; }

    public ExerciseViewModel(string name, MuscleViewModel muscle, string url)
    {
        Name = name;
        Muscle = muscle;
        Url = url;
    }

    public static ExerciseViewModel ToEntity(Exercise entity, ELanguage language) =>
        new(language == ELanguage.English ? entity.EnName : entity.PtName,
            MuscleViewModel.ToEntity(entity.Muscle, language), entity.ExerciseVideoUrl);
}