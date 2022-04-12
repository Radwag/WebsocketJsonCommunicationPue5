namespace Services.Commands.CommandModel
{
    public class KeyCommand
    {
        public KeyCommand(string commandName, string parameter, string key)
        {
            COMMAND = commandName;
            PARAM = parameter;
            KEY = key;
        }

        public string COMMAND { get; set; }
        public string PARAM { get; set; }
        
        public string KEY { get; set; }
    }
}
