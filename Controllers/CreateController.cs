using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

public class CreateController : Controller
{

    [HttpPost]
    public IActionResult CreatePost(Post post)
    {

		// Add new post to data/posts.json 
		var posts = Utils.GetPosts();

		// Add new post and re-serialize json
		post.Id = posts.Count;
		posts.Add(post);
		string json = JsonSerializer.Serialize(
			posts,
			new JsonSerializerOptions
			{
				WriteIndented = true
			});

		// Write to file
		System.IO.File.WriteAllText(Utils.filePath, json);

		// Return to home page
        return RedirectToAction(nameof(Success));
    }

	public IActionResult Success()
	{
		return Redirect("/Index");
	}
}
