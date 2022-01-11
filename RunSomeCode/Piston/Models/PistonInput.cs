namespace RunSomeCode.Piston.Models
{
    public class PistonInput
    {
        public string Language { get; set; }
        public string Version { get; set; }
        public PistonFile[] Files { get; set; }
    }
    public class PistonFile
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
