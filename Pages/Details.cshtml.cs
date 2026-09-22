using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages;

public class DetailsModel : PageModel
{

	public Post post = new() { Title = "", Body = ""};

    public void OnGet()
    {
		// Retrieve post data
		if (int.TryParse(Request.Query["id"], out int postId))
			post = Utils.GetPosts()[postId];

    }

}
