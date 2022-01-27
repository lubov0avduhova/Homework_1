// 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
// В результате вся информация выводится в одну строчку:

// запрашиваем информацию анкеты
Console.Write ("Скажи, как тебя зовут? ");
string name = Console.ReadLine();
Console.Write ("Твоя фамилия? ");
string lastname = Console.ReadLine();
Console.Write ("Твой возраст? ");
string age = Console.ReadLine();
Console.Write ("Рост? ");
string height = Console.ReadLine();
Console.Write ("Вес? ");
string weight = Console.ReadLine();

//а) используем склеивание;
Console.WriteLine ("А теперь результаты склеивания!");
Console.WriteLine ("Твое имя: " + name + " Фамилия " + lastname +
 " Возраст: " + age + " Рост: " + height + " Вес: " + weight);

// б) используем форматированный вывод;
Console.WriteLine ("А теперь результаты форматированного вывода!");
Console.WriteLine ("Твое имя:{0}" + " Фамилия: {1}" + " Возраст: {2}" + " Рост: {3}" + " Вес: {4}",
                name, lastname, age, height, weight);
// в) используя вывод со знаком $
Console.WriteLine ("А теперь результаты вывод со знаком $");
Console.Write ($"Твое имя: {name} Фамилия: {lastname} Возраст: {age} Рост: {height} Вес: {weight}");
