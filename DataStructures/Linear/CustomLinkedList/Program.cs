namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomLinkedList<string>();
            list.Add("Sofia");
            list.Add("Varna");
            list.Add("Burgas");
            list.Dump();

            list.InsertAfter("Plovdiv", "Sofia");
            list.Dump();
        }
    }
}
