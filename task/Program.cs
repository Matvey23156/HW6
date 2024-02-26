{
public static void Main(string[] args)
{
Console.WriteLine(result); }
{
string result = "";
{
for (int j = 0; j < array.GetLength(1); j++)
{

result += array[i, j]; }
}
return result; }
}
/*Задача 2: Замена заглавных букв на строчные в строке
public class Task2 {
public static void Main(string[] args) {
Console.WriteLine(result); }
}
Задача 3: Проверка строки на палиндром
public class Task3 {
public static void Main(string[] args) {

Console.WriteLine(isPalindrome ? "Да" : "Нет"); }

string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse()); }
}
Задача 4 (необязательная): Обратный порядок слов в строке
public class Task4 {
public static void Main(string[] args) {

string input = "Hello my world";
Console.WriteLine(result); }
{
return string.Join(" ", words); }
}
/*