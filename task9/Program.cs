// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру чисел.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99);
Console.WriteLine(number);  // Для вывода случайной цифры в ответе можно заменить на команду:
int digit2 = number % 10;   //Console.WriteLine($ "Наше случайное {number} число");
int digit1 = number / 10;   // называетс эта операция интерполяция
if (digit1 > digit2)
{
    Console.Write(digit1);
}
else
{
    Console.Write(digit2);
}
Console.WriteLine("-наибольшая цифра");

//void Foo()        // Невозвратный метод
//{
//    Console.Write("Невозвратный метод вызван");
//}
//int returnFoo()   // Возвратный метод:отличия void ничего нельзя записать слевой стороны
//{
//    return 1;