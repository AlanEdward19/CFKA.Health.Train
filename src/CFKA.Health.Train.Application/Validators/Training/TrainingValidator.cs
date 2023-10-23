using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Train.Application.Commands.CreateUpdateTraining;
using FluentValidation;

namespace CFKA.Health.Train.Application.Validators.Training;

public class TrainingValidator : AbstractValidator<CreateUpdateTrainingCommand>
{
    private readonly CFKATrainDbContext _dbContext;

    public TrainingValidator(CFKATrainDbContext dbContext)
    {
        _dbContext = dbContext;

        //RuleFor(x => x.)
    }
}