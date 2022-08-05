Console.Clear();
//Console.SetCursorPosition(10, 4); - Устанавливает положение курсора.
//Console.WriteLine("*");

int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 81, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya; // Для определенности добавляем некую точку с координатами.

int count = 0; // Счетчик, определяющий, сколько раз делить отрезки пополам.

while(count < 100000)
{
    int what = new Random().Next(0, 3); // [0;3] 0, 1, 2 - генерация случайного числа в диапазоне 3 точек треугольника
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++; // увеличение счетчика на 1

}