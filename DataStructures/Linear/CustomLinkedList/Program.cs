namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomLinkedList<string>();
            list.Insert("Sofia");
            list.Insert("Varna");
            list.Insert("Burgas");
            list.Dump();

            list.InsertAfter("Plovdiv", "Sofia");
            list.Dump();

            list.InsertAfter("Vidin", "Varna");
            list.Dump();

            list.Remove("Vidin");
            list.Dump();

            list.Clear();
            list.Dump();
        }
    }
}
