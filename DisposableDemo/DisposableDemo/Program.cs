namespace DisposableDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // The 'using' keyword ensures that Dispose() will be called automatically
            // even if an exception occurs inside the block.
            // Without 'using', Dispose() must be called manually, otherwise resources may leak.
            using (DemoResource demoResource = new())
            {
                try
                {
                    demoResource.DoWork();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Program.cs is done.");
            
        }
    }
}
