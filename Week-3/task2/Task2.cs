

namespace Workshop
{
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string? username = null;
            string ternaryResult = (username == null) ? "Username is not available" : username;
            Console.WriteLine("Ternary check: " + ternaryResult);
            string coalescingResult = username ?? "Username is not available";
            Console.WriteLine("Null-coalescing (??) check: " + coalescingResult);
            username ??= "default_user";
            Console.WriteLine("After null-coalescing assignment (??=): " + username);
        }
    }
    
}
