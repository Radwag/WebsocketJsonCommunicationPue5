namespace Services.Commands.CommandModel
{
    public class Command
    {
        public Command(string commandName, string parameter)
        {
            COMMAND = commandName;
            PARAM = parameter;
        }

        public string COMMAND { get; set; }
        public string PARAM { get; set; }
    }
}
