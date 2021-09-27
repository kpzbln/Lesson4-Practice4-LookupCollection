﻿using System;
using System.Globalization;
using System.Collections;
using System.Collections.Specialized;

namespace Lesson4_Practice4_LookupCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создать cловарь, нечувствительный к регистру 

            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            // Добавить несколько элементов

            list["Estados Unidos"] = "United States of America";
            list["Canada"] = "Canada";
            list["Espana"] = "Spain";

            //  Показать результаты

            Console.WriteLine(list["espana"]);
            Console.WriteLine(list["CANADA"]);
        }
    }
}