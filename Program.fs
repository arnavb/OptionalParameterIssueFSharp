// The code below runs as expected in .NET 8.0.300, but breaks in previous versions. Why?

open Discord

let testCommandBuilder =
    (new SlashCommandBuilder())
        .WithName("list-roles")
        .WithDescription("Lists all roles of a user.")
        .AddOption(
            "user",
            ApplicationCommandOptionType.User,
            "The users whos roles you want to be listed",
            isRequired = true
        )
