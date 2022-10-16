/* Задача 3: Вывести все возможные сочетания из букв (4 буквы) */

// int n = 1; 

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return; 
//     }
//     for(int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1); 
//     }
// }
// FindWords("фисв", new char[4]); 


/* Задача 4: Игра в пирамидки */

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // 1 – первый шпиль, 3 - третий шпиль, 2 - промежуточный шпиль, count – количество блинов
{
    if(count > 1) Towers(with, some, on, count - 1); 
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1); 
}

Towers();

