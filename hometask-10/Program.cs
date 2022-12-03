namespace hometask_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            MyList<int> list2 = new MyList<int>(10);


            list2[0] = 1;
            list2[1] = 2;
            list2[2] = 3;
            list2[3] = 4;
            list2[4] = 5;
            list2[5] = 6;
            list2.Add(7);
            list2.Add(8);
            Console.WriteLine(list2.Contains(9));
            list2.GetAll();


            //list.Add("salam");
            //list.Add("as");
            //list.Add("necesen");
            //list.Add("yaxs");
            //list.Add("yaxs");
            //list.Add("yaxs");
            //list.Add("sen");
            //list[3] = "ok";

            //Console.WriteLine(list.Contains("fijasdf"));
            //Console.WriteLine(list.Contains("necesen"));

            //list.Remove("ok");
            //Console.WriteLine(list.IndexOf("yaxs"));
            //Console.WriteLine(list.LastIndexOf("yaxs"));
            //list.GetAll();

            //list.Reverse();
            //list.GetAll();

            //list.Clear();
            //list[0] = "salammmm";
            //list[1] = "saldadadadaammmm";
            //list.Add("SAUDHASD");
            //list.GetAll();
        }
    }
}