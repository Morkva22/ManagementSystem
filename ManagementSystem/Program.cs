namespace ManagementSystem;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            var supa = new SupabaseRepository(
                @"https://hewjyfyclvgidnaneior.supabase.co", 
                @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imhld2p5ZnljbHZnaWRuYW5laW9yIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc1MDM1NDA2NSwiZXhwIjoyMDY1OTMwMDY1fQ.xRu_N4sK1idDS2C__uLP951SXBEBUcePN7tqgjtBCW0"
            );
            
            await supa.InitDatabase();

            var result = await supa.SupabeseClient?.From<ProductModel>().Get();
            var parsedResult = result.Models.ToList();
            foreach (var item in parsedResult)  {  Console.WriteLine($"ID: {item.id}, Created At: {item.created_at}");  }
        }
        catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
    }
}