// See https://aka.ms/new-console-template for more information
Console.WriteLine("*******************    Water bill calculation program   ****************");

/// test git

//Declare the function to handle the program
void Preparethebill()
{
    Console.WriteLine("Enter the customer's First and Last Name : ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please select customer type");
    Console.WriteLine("Enter number 1 if you are a household customer, then press enter");
    Console.WriteLine("Enter number 2 if you are a public administration customer type, then press enter");
    Console.WriteLine("Enter number 3 if you are a production unit customer type, then press enter");
    Console.WriteLine("Enter number 4 if you are a business services type customer, then press enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // Household customers
        // Requires number of family members
        Console.WriteLine("Enter the number of family members");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter the previous month's copper index");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter this month's copper index");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine(customer);
                Console.WriteLine("Consumption amount {0}", waterNumber,"m3");
                Console.WriteLine( "Your family's water bill is : {0}", money,"VND/m3");
            }
            else
            {
                Console.WriteLine("The number of countries in the previous month is not greater than that of the current month");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // Administrative agency customers
        Console.WriteLine("Enter the previous month's copper index");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month's copper index");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine(customer);
            Console.WriteLine("Consumption amount {0}", waterCurrentMonth - waterLastMonth,"m3");
            Console.WriteLine( "Water fees Administrative agencies and public services {0}", m,"VND/m3");
        }
        else
        {
            Console.WriteLine("The number of countries in the previous month is not greater than that of the current month");
        }
    }
    else if (typeCustomer == 3)
    {
        // Manufacturing unit customers
        Console.WriteLine("Enter the previous month's copper index");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month's copper index");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine(customer);
            Console.WriteLine("Consumption amount {0}", waterCurrentMonth - waterLastMonth, "m3");
            Console.WriteLine("Water bill of production unit {0}", m, "VND/m3");
        }
        else
        {
            Console.WriteLine("The number of countries in the previous month is not greater than that of the current month");
        }
    }
    else if (typeCustomer == 4)
    {
        // Business customers
        Console.WriteLine("Enter the previous month's copper index");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month's copper index");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 22068 * 1.1;
            Console.WriteLine(customer);
            Console.WriteLine("Consumption amount {0}", waterCurrentMonth - waterLastMonth, "m3");
            Console.WriteLine("Water charges for business services {0}", m , "VND/m3")  ;
        }
        else
        {
            Console.WriteLine("The number of countries in the previous month is not greater than that of the current month");
        }
    }
    else
    {
        Console.WriteLine("Please re-enter the exact verbiage to replace the customer");
    }
}

Preparethebill();
