// Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] array = {"5gg", "12sdf", "55dbd","Hello", "2", "world", ":-)"};
Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
void NewArray(string[] array){
    int j=0;
    int count=0;
   for (int i=0; i<array.Length; i++){
      if (array[i].Length<=3){
      count++;
      }
}
    string[] array2 = new string[count];
    for (int i=0; i<array.Length; i++){
      if (array[i].Length<=3){
        array2[j] = array[i];
        j++;
        }
    }
    Console.WriteLine($"Полученный массив: [{string.Join(", ", array2)}]");
}
NewArray(array);