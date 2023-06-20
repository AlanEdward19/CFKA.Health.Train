using System.ComponentModel.DataAnnotations;

namespace CFKA.Health.Domain.Entities;

public class Muscle
{
    [Key]
    public int Id { get; set; }
    public EMuscle MainMuscle { get; set; }
    public string EnName { get; set; }
    public string PtName { get; set; }

    public string GetMuscleName(ELanguage language) => language switch
    {
        ELanguage.English => EnName,
        ELanguage.Portuguese => PtName
    };

    public string GetMainMuscleName(ELanguage language) => (language, MainMuscle) switch
    {
        (ELanguage.Portuguese, EMuscle.Chest) => "Peitoral",
        (ELanguage.Portuguese, EMuscle.Back) => "Costas",
        (ELanguage.Portuguese, EMuscle.Shoulder) => "Ombros",
        (ELanguage.Portuguese, EMuscle.Biceps) => "Bíceps",
        (ELanguage.Portuguese, EMuscle.Triceps) => "Tríceps",
        (ELanguage.Portuguese, EMuscle.Abs) => "Abdomen",
        (ELanguage.Portuguese, EMuscle.Calves) => "Panturrilha",
        (ELanguage.Portuguese, EMuscle.Quadriceps) => "Quadríceps",
        (ELanguage.Portuguese, EMuscle.Glutes) => "Glúteos",
        (ELanguage.Portuguese, EMuscle.Forearms) => "Antebraço",
        _ => MainMuscle.ToString()
    };
}