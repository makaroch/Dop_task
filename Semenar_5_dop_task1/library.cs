namespace MyLibrary
{
    class library
    {
        public static int[] MyCreateArrayInt(int length,int minValue = 0,int maxValue = 99){
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(minValue,maxValue+1);
            }
            return arr;
        }

        public static void MyLookArray(int[] arr){

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ ", ");
            }
            Console.WriteLine();
        }

        public static int MyReadCons(){
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        public static void MyRotationArray(int[] arr){
            
            int temp = 0;
            int j = 1;
            for (int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[arr.Length-j];
                arr[arr.Length-j] = arr[i];
                arr[i] = temp;
                j--;
            }
            
        }

    }
}