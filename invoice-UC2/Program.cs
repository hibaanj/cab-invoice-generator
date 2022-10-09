namespace invoice_UC2
{
    public class program
    {


        public static void Main(string[] args)
        {
            Invoicegenerator invoicegenerator = new Invoicegenerator();
            invoicegenerator.totalcost(300.50, 15.2);
            invoicegenerator.totalcost(200.3, 12.1);
            invoicegenerator.totalcost(20.5, 5.3);


            Multiplerides multiplerides = new Multiplerides();
            Console.WriteLine("the total ride fare is " + multiplerides.totalcost);
        }

    }
}