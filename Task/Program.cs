﻿// Из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

string[] array1 = new string[5] { "hello", "-2", "111", ":-", "Russia" };
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
        }
        count++;
    }
}