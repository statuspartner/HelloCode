// Вид1 (ничего не принимают, ничего не возвращают)
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1(); // Вызов метода



// Вид2 (принимают какие-то аргументы, ничего не возвращают)

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
Method2(msg: "Текст сообщения"); // Именованные аргументы - какому агрументу какое значение хотим указать (часто нужно, когда методы принимают какое-то количество агрументов)
*/

void Method21(string msg, int count)
{
    int i= 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент - увеличение счетчика на единицу. (уменьшение на 1 - декремент)
    }
}
// Method21(msg: "Текст", count: 3);
// Method21(count: 3, msg: "новый текст");



// Вид3 (ничего не принимают, что-то возвращают)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);


// Вид4 (что-то принимают, что-то возвращают)

/*
string Method4(int count, string text)    // будем возвращать строку string, а передавать строку 'c' int count раз.
{
    int i = 0;
    string result = String.Empty; // в переменную передаем пустую строку, указывая правильно или так: "";
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/

// Вид4 (что-то принимают, что-то возвращают)

/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)  // for(инициализация счетчика; проверка условия; инкремент)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); // интерполяция строк
    }
    Console.WriteLine();
}
*/

/*
====== Работа с текстом ======
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".
*/
// string s = "qwerty"
//             012345
// s[3] == r

string text = "- Я думаю, Сказал князь, улыбаясь, - что "
            + "ежели бы вас послали вместо нашего Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю-С?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //1 шаг

    int length = text.Length;   //3 шаг
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";    //text[i] - текущий символ
        else result = result + $"{text[i]}";
    }

    return result; //2 шаг
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
