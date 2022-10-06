using MyLibrary;


void Task4_5()
{
    /*Задача 1*. Дан массив массивов, состоящих из натуральных чисел, размер 
    которого 5. Для каждого элемента-массива требуется найти сумму его элементов и 
    вывести массив с наибольшей суммой. Если таких массивов несколько, 
    вывести массив с наименьшим индексом.
    */

    int[][] arrayArr = new int[5][];

    arrayArr[0] = library.MyCreateArray(10, 0, 10);
    arrayArr[1] = library.MyCreateArray(10, 0, 10);
    arrayArr[2] = library.MyCreateArray(10, 0, 10);
    arrayArr[3] = library.MyCreateArray(10, 0, 10);
    arrayArr[4] = library.MyCreateArray(10, 0, 10);

    int size = arrayArr.Length;
    int sum = 0;
    int sumTemp = 0;
    int indexMaxSum = 0;
    for (int i = 0; i < size; i++)
    {
        sumTemp = 0;
        for (int j = 0; j < arrayArr[i].Length; j++)
        {
            sumTemp += arrayArr[i][j];
        }
        Console.WriteLine($"сумма {i} массива {sumTemp}");
        if (sumTemp > sum)
        {
            sum = sumTemp;
            indexMaxSum = i;
        }
    }
    Console.WriteLine($"массив с наибольшей суммой элементов {indexMaxSum}");
    library.MyLookArray(arrayArr[indexMaxSum]);
}


/*Задачки из 6 семенара на рекурсию*/


void Task1(){
    /*Задача 1. Написать перевод десятичного числа 
    в двоичное, используя рекурсию.
    */

    int x = library.MyReadCons();

    DecToBin(x);

}
//Task1();

void DecToBin(int num, string res=""){

    if (num / 2 == 0 ) {
        res = Convert.ToString(num%2) + res;
        Console.WriteLine(res);
        return;
    }
    res = Convert.ToString(num%2) + res;
    num /= 2;
    Console.WriteLine(res);
    
    DecToBin(num,res);
}

void Task2(){
    /*Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
    Используя рекурсию, подсчитайте, сколько в поговорке гласных букв*/

    string A = "“без труда не выловишь и рыбку из пруда”";
    Glasn(A);
    
}
//Task2();
void Glasn(string fraz, int j = 1, int count=0){
    int i = fraz.Length - j;
    if ( fraz[i] == '“') return;
    if (fraz[i] == 'а' || fraz[i] == 'о'){
        count++ ;
        Console.WriteLine(count);
    }

    Glasn(fraz, j++, count);
}

void Task3(){

    /*Задача 3. Дано число N. Используя только операцию деления и рекурсию,
    определите, что оно является степенью числа 3.*/

    int x = library.MyReadCons();
    Division(x);
}
//Task3();
void Division(double n){

    if (n / 3 == 1) {
        Console.WriteLine("число является степенью числа 3");
        return;
    }
    if (n / 3 == 0) {
        Console.WriteLine("число не является степенью числа 3");
        return;
    }
    n /= 3;
    Division(n);

}

