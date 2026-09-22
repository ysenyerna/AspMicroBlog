using System.Text.Json;

public class Utils
{

	public const String filePath = "data/posts.json";
	
	// Retrieves posts from data/posts.json and returns a list
	public static List<Post> GetPosts()
	{
		List<Post> posts = [];

		string existingJson = System.IO.File.ReadAllText(filePath);
		if (!string.IsNullOrWhiteSpace(existingJson))
		{
			posts = JsonSerializer.Deserialize<List<Post>>(existingJson) ?? [];
		}
		return posts;
	}
}