using MyLibrary;

void task1()
{
/*Задача 1. Задан массив из случайных цифр на 15 элементов. 
На вход подаётся трёхзначное натуральное число. Напишите программу, 
которая определяет, есть в массиве последовательность из трёх элементов, 
совпадающая с введённым числом.
{0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
{4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет
*/

    int[] array = library.MyCreateArrayInt(15,0,9);
    library.MyLookArray(array);
    int x = library.MyReadCons();

    int [] newArray = new int[3];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = x % 10;
        x /=10; 
    }

    library.MyRotationArray(newArray);
    SearchNum(array,newArray);

}
 
void SearchNum(int[] arr1, int[] arr2){
    int i = 0;
    bool bol = false;
    for (int j = 0; j < arr1.Length - 2; j++)
    {
        if (arr2[i] == arr1[j] && arr2[i+1] == arr1[j+1] && arr2[i+2] == arr1[j+2]) {
        bol = true;
        j = arr1.Length;
        }
    }
    if (bol) Console.WriteLine("такое число есть");
    else Console.WriteLine("нет такого числа");
}

void task3() {
    /*Задача 3. Найдите все числа от 1 до 1000000, 
    сумма цифр которых в три раза меньше их произведений. 
    Подсчитайте их количество.
*/

for (int i = 0; i < 1000000; i++)
{
    
}


}

void SumNumber(int x){

    
}