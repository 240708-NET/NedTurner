namespace Sin.Repo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IRepo repo = new FileReader();

            List<List<string>> tips = repo.ReadCsv();

            FileReader.Print2DArray(tips);
        }
    }

}