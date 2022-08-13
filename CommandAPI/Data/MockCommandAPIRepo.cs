using CommandAPI.Models;

namespace CommandAPI.Data;

public class MockCommandAPIRepo : ICommandAPIRepo
{
    public void CreateCommand(Command command) => throw new NotImplementedException();

    public void DeleteCommand(Command command) => throw new NotImplementedException();

    /// <summary>
    /// Return a collection of all the commands.
    /// </summary>
    /// <returns>The colletion of commands.</returns>
    public IEnumerable<Command> GetAllCommands()
    {
        List<Command> commands = new()
        {
            new()
            {
                Id = 0,
                HowTo="How to generate a migration",
                Platform=".Net Core EF",
                CommandLine="dotnet ef migrations add <Name of Migr"
            },
            new()
            {
                Id=1,
                HowTo="Run migrations",
                Platform=".Net Core EF",
                CommandLine="dotnet ef database update"
            },
            new()
            {
                Id=2,
                HowTo="List active migrations",
                Platform=".Net Core EF",
                CommandLine="dotnet ef migrations list"
            },
        };

        return commands;
    }

    /// <summary>
    /// Return the command with the given id.
    /// </summary>
    /// <param name="id">The id of the command to return.</param>
    /// <returns></returns>
    public Command GetCommandById(int id) => new()
    {
        Id = id,
        HowTo = "How to generate a migration",
        Platform = ".Net Core EF",
        CommandLine = "dotnet ef migrations add <Name of Migration>"
    };

    public bool SaveChanges() => throw new NotImplementedException();

    public void UpdateCommand(Command command) => throw new NotImplementedException();
}
