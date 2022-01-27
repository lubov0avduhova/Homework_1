// 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
//  где m — масса тела в килограммах, h — рост в метрах.

Console.WriteLine ("Узнаем твой индекс массы тела");

//узнаем данный для формулы
Console.Write ("Введи твой вес ");
double weight = double.Parse (Console.ReadLine());
Console.Write ("А теперь рост ");
int height = int.Parse (Console.ReadLine());

double result = weight/(height * height);

Console.WriteLine ("{0:F4}", result);