namespace LongestIncSubseqApi
{
    public interface IniLongestIncSubseq
    {
        string input { get; set; }
        string output { get; set; }

        string LISFlow(string inputvalue);
    }
}