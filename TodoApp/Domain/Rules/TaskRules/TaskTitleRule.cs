using Shared.Core.Domain.Validators;

namespace TodoApp.Domain.Rules.TaskRules;

public class TaskTitleRule : BaseNoParamValidator<string, TaskTitleRule>
{
    public TaskTitleRule()
    {
        // TODO
    }
}