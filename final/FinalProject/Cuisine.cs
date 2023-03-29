class AllRecipes
{
    private List<Recipe> allRecipes = new List<Recipe>();
    public void addRecipe(Recipe _recipe)
    {
        allRecipes.Add(_recipe);
    }
    public void DisplayRecipes()
    {
        if (allRecipes.Count() == 0)
        {
            Console.WriteLine("You haven't found a recipe that you like. ");
        }
        else
        {
            Console.WriteLine($"Here are the {allRecipes} you chose");
        }
    }
    public void SaveRecipes()
    {
        if (allRecipes.Count() == 0)
        {
            Console.Write("There are no recipes to save. ");
            return;
        }
        List<string> saveRecipes = new List<string>();
        foreach (Recipe recipe in allRecipes)
        {
          saveRecipes.Add(recipe.ToCSVRecord());
        }
    }
    
}