using System.ComponentModel.DataAnnotations;

public class Post
{
	public int Id { get; set; } 
	[Required] public required string Title { get; set; } 
	[Required] public required string Body { get; set; } 
	public DateTime CreatedUtc { get; set; } = DateTime.UtcNow; 

}