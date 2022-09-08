int i;
 
            Console.Write("Введите число: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("{0} Чётное число", i);
            }
            else
            {
                Console.Write("{0} Нечётное число", i);
            }