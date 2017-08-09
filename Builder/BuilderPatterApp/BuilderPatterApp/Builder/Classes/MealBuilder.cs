using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            Meal _meal = new Meal();
            _meal.addItem(new VegBurger());
            _meal.addItem(new Milk());
            return _meal;
        }

        public Meal prepareNonVegMeal()
        {
            Meal _meal = new Meal();
            _meal.addItem(new FishBurger());
            _meal.addItem(new Coke());
            return _meal;
        }
    }
}
