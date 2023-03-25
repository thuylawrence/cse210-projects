using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        int userMainMenuChoices = 0;

        while (userMainMenuChoices != 6)
        {
            Menu menu = new Menu();
            allGoals.DisplayPoints();

            userMainMenuChoices = menu.DisplayGetMainMenu();
            switch (userMainMenuChoices)
            {
                case 1:
                    Goal goal = null;
                    int createNewGoalSelection = menu.DisplayGetCreateGoalMenu();

                    switch (createNewGoalSelection)
                    {
                        case 1:
                            goal = new SimpleGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        case 2:
                            goal = new EternalGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        case 3:
                            goal = new CheckListGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        
                    }
                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }
                    break;
                case 2:

                    allGoals.DisplayGoals();
                    break;
                case 3:
                    allGoals.SaveGoals();
                    break;
                case 4:
                    allGoals.LoadGoals();
                    break;
                case 5:
                    allGoals.DisplayGoalsRecordEvent();
                    break;
            }

        }

    }
}