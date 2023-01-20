#region Задание 2
    bool IntersectionLines(double b1,double k1,double b2,double k2){
        double x = (b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;

        if(x == y) return true;
        return false;
    }

    void Result(){
        Console.Write("Введите первую точку, первого отрезка: ");
        int b1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите вторую точку, первого отрезка: ");
        int k1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите первую точку, второго отрезка: ");
        int b2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите вторую точку, второго отрезка: ");
        int k2 = Convert.ToInt32(Console.ReadLine());

        if(IntersectionLins(b1,k1,b2,k2) == true) Console.WriteLine("Отрезки пересекаются");
        else Console.WriteLine("Отрезки не пересекаются");
    }

    Result();

    
#endregion
