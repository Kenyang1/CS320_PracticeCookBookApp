using Microsoft.AspNetCore.Mvc;

//Tells .NET that this file is an API controller
[ApiController]
// Creates an API endpoint at /api/recipe
[Route("api/recipe")]
public class RecipeController : ControllerBase
{
    [HttpGet]

    // The function will run when someone visits the endpoint
    public IActionResult GetRecipe()
    {
        var recipe = new
        {
            id = "1",
            name = "Pancakes",
            category = "Breakfast",
            steps = new[]
            {
                "Mix all ingredients in a bowl.",
                "Heat a pan and pour the batter.",
                "Cook until golden brown on both sides."
            },
            ingredients = new[] { "Flour", "Milk", "Egg", "Butter", "Sugar" }
        };

        // this sends back the recipe data in JSON format
        return Ok(recipe);
    }
}
