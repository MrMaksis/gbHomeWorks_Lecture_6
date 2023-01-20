#region Задание 1
void NumMoreNull()
{
    string num = " ";
    int numericValue;

    while(num != "stop")
    {
        Console.Write("Введити число/команду: ");
        num = Console.ReadLine();

        bool isNumber = int.TryParse(num, out numericValue);

        if(isNumber == true){
            if(Convert.ToInt32(num) > 0){
                Console.WriteLine($"Число {num} > 0");
            }
        }
        else{
            Console.WriteLine("Программа завиршила работу!");
            break;
        }
    }
}
NumMoreNull(); 
#endregion

