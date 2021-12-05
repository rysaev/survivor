﻿using System;
using System.Collections.Generic;

/// <summary>
/// Мастер ключей
/// </summary>
///
/*

Мастер ключей
заключительное

По совету Оракула, Нео освобождает из замка Меровингена системную программу-изгнанника -- Мастера ключей. Только Мастер ключей поможет Избранному найти Архитектора и положить конец войне.
Однако у них совсем мало времени -- армия Агентов Смитов уже совсем близко. Нео требуется знать лишь набор секретных дверей, но они будут выявлены только после того, как Мастер ключей будет открывать и закрывать двери по определённому алгоритму.
Помогите Избранному -- вычислите заранее двери, которые будут открыты по окончании работы Мастера ключей.
Имеется k дверей (например, массив из k логических элементов). Каждая дверь может быть либо открыта, либо закрыта. Исходно все двери закрыты.
Мастер ключей выполняет k манипуляций над дверями. На первом шаге он открывает все двери. На втором шаге он закрывает каждую вторую дверь. На третьем шаге он проверяет каждую третью дверь, открывает её если она закрыта, и закрывает если открыта.
Далее, на n-м шаге он таким образом "переключает" каждую n-ю дверь.
Соответственно, на последнем шаге n=k он "переключит" только самую последнюю дверь. Нео должен знать, сколько и каких дверей после k таких манипуляций будут открыты.

Задание.
1. Напишите программу, которая моделирует работу Мастера ключей.
2. Поэкспериментируйте с разными значениями k, постарайтесь выявить закономерность, от чего зависят номера открытых дверей.
3. Попробуйте объяснить эту закономерность математически.

Пункты 2 и 3 расскажите преподавателю в чате (бонус до +1000 золотых).

Функция
string Keymaker(int k)
получает на вход количество дверей k и возвращает строку длиной k символов, где 1 в i-й позиции означает открытую i-ю дверь, а 0 -- закрытую i-ю дверь. 
*/
#region 
///Золота: 2300$
//вилка цены: 4700 - 5300 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static string Keymaker(int k)
        {
            return "";
        }
        
        static void Main()
        {
            int k = 5;

            Console.WriteLine("результат: " + Level1.Keymaker(k));
            Console.ReadKey();
        }
    }
}
#endregion
