using System;

public abstract class Recipe
{
    protected string _recipeName;
    protected string _recipeDescription;
    protected float _cookingTime;

    protected Recipe(string recipeName, string recipeDescription, float cookingTime)
    {
        _recipeName = recipeName;
        _recipeDescription = recipeDescription;
        _cookingTime = cookingTime;
    }
    protected Recipe()
    {
        Console.Write("What recipe are your looking for? ");
        _recipeName = Console.ReadLine();
        Console.Write("Tell us more about the dish that you want to make! ");
        _recipeDescription = Console.ReadLine();
        Console.Write("How much time do you have to cook? ");
        _cookingTime = int.Parse(Console.ReadLine());
    }
    public string GetRecipeName()
    {
        return _recipeName;
    }
    public string GetRecipeDescription()
    {
        return _recipeDescription;
    }
    public float GetCookingTime()
    {
        return _cookingTime;
    }
    public abstract string ToCSVRecord();
    public void DisplayGetRecipeName()
    {
        Console.WriteLine(GetRecipeName());
    }
    public void DisplayGetRecipeDescription()
    {
        Console.WriteLine(GetRecipeDescription());
    }
    public void DisplayGetCookingTime()
    {
        Console.WriteLine(GetCookingTime());
    }


}