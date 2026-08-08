using System;

class Program
{
    static void Main()
    {
        double totalExpense = 0;

        try
        {
            Console.Write("Enter Expense Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Expense Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= 0)
            {
                throw new Exception("Expense amount must be greater than 0.");
            }

            totalExpense += amount;

            Console.WriteLine("\nExpense Added Successfully!");
            Console.WriteLine("Category : " + category);
            Console.WriteLine("Amount   : " + amount);
            Console.WriteLine("Total Expense : " + totalExpense);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input! Please enter numbers only.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}