using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages;

public class IndexModel : PageModel
{

	public List<Post> PostData = [];

    public void OnGet()
    {
		// Retrieve post data
		PostData = Utils.GetPosts();

    }
}
