namespace JsontoCsv
{
    public interface IFileModel
    {
        string Name { get; set; }
        string FilePath { get; set; }
        object Data { get; set; }
    }
}