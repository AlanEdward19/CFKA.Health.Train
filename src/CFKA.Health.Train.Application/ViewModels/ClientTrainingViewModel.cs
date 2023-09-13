namespace CFKA.Health.Train.Application.ViewModels;

public class ClientTrainingViewModel
{
    public string ClientName { get; set; }
    public string ClientEmail { get; set; }
    public IEnumerable<TrainingViewModel> Trainings { get; set; }

    public ClientTrainingViewModel(string clientName, string clientEmail, IEnumerable<TrainingViewModel> trainings)
    {
        ClientName = clientName;
        ClientEmail = clientEmail;
        Trainings = trainings;
    }
}