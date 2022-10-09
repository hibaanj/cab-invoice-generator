namespace invoice
{
    public class program
    {
        public static void Main(string[] args)
        {
            Invoicegenerator invoicegenerator = new Invoicegenerator();
            Console.WriteLine("the total expected are if the distance and time assumed is : " + invoicegenerator.totalcost(300.50, 15.2));
        }

    }
}