using MyLibrary;

/*Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. 
Определите самый часто встречающийся элемент в массиве. 
Если таких элементов несколько, вывести их все.
*/
void Semenar4DopTaskThree(){
    int[] array = library.CreateArrayInt(100,1,100);
    library.LookArray(array);
    OftenElement(array);
}

void OftenElement(int[] arr){
    int count = 1;
    int countTemp=0;
    int tempElement = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        countTemp = 0;

        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] == arr[j]) countTemp++;
        }

        if (countTemp > count) 
        {
            Console.WriteLine($"число {arr[i]} встречается {countTemp} раз");
            tempElement = arr[i];
            //count = countTemp;
        }   
    }
    if (tempElement == -1) Console.WriteLine("всех по одному");
    //else Console.WriteLine($"элемент {tempElement} встречается {count} раз");
}
Semenar4DopTaskThree();