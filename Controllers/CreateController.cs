using Microsoft.AspNetCore.Mvc;

public class CreateController : Controller
{

    [HttpPost]
    public IActionResult CreatePost(Post post)
    {


        return RedirectToAction(nameof(Success));
    }

	public IActionResult Success()
	{
		return Redirect("/Index");
	}
}
