// Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.

   Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        int temp = number;
        
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit;
            
            temp /= 10;
        }
        
        Console.WriteLine("Сумма цифр в числе {0} равна {1}", number, sum);
