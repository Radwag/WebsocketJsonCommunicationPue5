namespace Services.Commands.CommandModel
{
    public class DataKeyCommand
    {
        public DataKeyCommand(string commandName, string parameter, string key, string data)
        {
            COMMAND = commandName;
            PARAM = parameter;
            KEY = key;
            DATA = data;
        }

        public string COMMAND { get; set; }
        public string PARAM { get; set; }
        public string KEY { get; set; }
        public string DATA { get; set; }
    }
}
