using System;
using System.Reflection;

public partial class Recipe
{
    public string Name { get; }
    public int Servings { get; }

    private string[] ingredients;
    private int ingredientCount;

    public Recipe(string name, int servings, int maxIngredients)
    {
        this.Name = name;
        this.Servings = servings;
        this.ingredients = new string[maxIngredients];
        this.ingredientCount = 0;
    }
}

public partial class Recipe
{ 
    public void AddIngredient(string ingredient)
    {
        if (ingredientCount < ingredients.Length)
        {
            ingredients[ingredientCount] = ingredient;
            ingredientCount++;
        }
        else
        {
            Console.WriteLine($"[알림] {Name}의 재료가 가득 찼습니다. 더 이상 추가할 수 없습니다.");
        }
    }

    public bool HasIngredient(string ingredient)
    {
        for (int i = 0; i < ingredientCount; i++)
        {
            if (ingredients[i] == ingredient) return true;
        }
        return false;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");
        for (int i = 0; i < ingredientCount; i++)
        {
            Console.WriteLine($"{i + 1}. {ingredients[i]}");
        }
    }
}
