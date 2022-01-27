// 3.а) Написать программу, которая подсчитывает расстояние между точками с координатами
//  x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
//  Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

Console.Write ("Напиши первое число - х1 ");
double x1 = double.Parse (Console.ReadLine ());
Console.Write ("Второе число - у1 ");
double y1 = double.Parse (Console.ReadLine ());
Console.Write ("Третье число х2 ");
double x2 = double.Parse (Console.ReadLine ());
Console.Write ("Четвертое число у2 ");
double y2 = double.Parse (Console.ReadLine ());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

Console.WriteLine("{0:F2}", result);



// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
