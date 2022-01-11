namespace RunSomeCode.Piston.Models
{
    public class PistonOutput
    {
        public string Language { get; set; }
        public string Version { get; set; }
        public PistonGenricOutput Run { get; set; }
        public PistonGenricOutput Compile { get; set; }

    }

    public class PistonGenricOutput
    {
        public string Stdout { get; set; }
        public string stderr { get; set; }
        public int Code { get; set; }
        public string Signal { get; set; }
        public string Output { get; set; }
    }

    public class PistonBadOutput
    {
        public string Message { get; set; }
    }

}

