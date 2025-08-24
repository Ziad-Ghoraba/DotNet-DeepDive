namespace DisposableDemo
{
    // DemoResource simulates a class that manages an external resource (e.g., database connection, file, socket).
    // It implements IDisposable so cleanup logic can be enforced via Dispose().
    public class DemoResource : IDisposable
    {
        // Dispose() is called automatically at the end of the 'using' block.
        // In real-world scenarios, this is where you release resources like:
        // - Closing database connections
        // - Disposing file streams
        // - Releasing network sockets
        public void Dispose()
        {
            Console.WriteLine("Closing Connection via Disposable");
        }

        // Simulates work that opens a connection, does something,
        // and throws an exception before cleanup.
        // Thanks to 'using', Dispose() will still run.
        public void DoWork()
        {
            Console.WriteLine("Open Connection .....");
            Console.WriteLine("Doing work .....");
            throw new Exception("I broke");
            Console.WriteLine("Closing Connection .....");
        }
    }
}
