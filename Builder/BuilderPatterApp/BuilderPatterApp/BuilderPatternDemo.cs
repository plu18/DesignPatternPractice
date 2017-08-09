using BuilderPatterApp.Builder.Classes;
using System;

namespace BuilderPatterApp
{
    class BuilderPatternDemo
    {
        static void Main(string[] args)
        {
            MealBuilder _mealBuilder = new MealBuilder();
            Meal vegMeal = _mealBuilder.prepareVegMeal();
            vegMeal.showItems();


            Meal nonVegMeal = _mealBuilder.prepareNonVegMeal();
            nonVegMeal.showItems();

            Console.ReadKey();

        }
    }
}