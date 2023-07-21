using System;
using System.Globalization;
class bee1048
{

    static void Main(string[] args)
    {
        float salary, increment, percentage;


        salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salary >= 0 && salary <= 400.00)
        {
            percentage = 15;
            

            increment = (percentage / 100) * salary;

            
            salary = salary + increment;

        }
        else if (salary >= 400.01 && salary <= 800.00)
        {
            percentage = 12;
            increment = (percentage / 100) * salary;

            
            salary = salary + increment;


        }
        else if (salary >= 800.01 && salary <= 1200.00)
        {
            percentage = 10;
            increment = (percentage / 100) * salary;

            
            salary = salary + increment;
        }
        else if (salary >= 1200.01 && salary <= 2000.00)
        {
            percentage = 7;
            increment = (percentage / 100) * salary;

            
            salary = salary + increment;
        }
        else if (salary >= 2000.00) {
            percentage = 4;
            increment = (percentage / 100) * salary;

            
            salary = salary + increment;
        }
        else {
            percentage= 0;
            increment = 0; 
        }
        Console.WriteLine("New salary: " + salary.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("new readjustment: " + increment.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("in percentage: " + percentage+ " %");
    }

}