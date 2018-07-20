namespace Google.Service.Dtos
{
    public class LogDto
    {
        public long Id { get; private set; }

        public string Application { get; private set; }

        public string Logged { get; private set; }

        public string Level { get; private set; }

        public string Message { get; private set; }

        public string Logger { get; private set; }

        public string Callsite { get; private set; }

        public string Exception { get; private set; }
    }
}