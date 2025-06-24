namespace ManagementSystem;

using Supabase;

public interface ISupabaseRepository
{
    Task InitDatabase();
}

public class SupabaseRepository : ISupabaseRepository
{
    public Client SupabeseClient { get; private set; } = null!;
    private string _url { get; set; }
    private string _key { get; set; }
    
    private string _defaultSchema = "public";

    public SupabaseRepository(string Url, string Key) { _url = Url; _key = Key; }
    
    public async Task InitDatabase()
    {
        try
        {
            SupabaseOptions options = new SupabaseOptions { AutoConnectRealtime = true };
            SupabeseClient = new Client(_url, _key, options);
        }
        catch (Exception e) { throw new Exception($"Erroring to connect to Supabase: {e.Message}", e); }
    }
} 