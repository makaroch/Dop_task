namespace MyLibrary
{
    class library
    {
        public static int[] CreateArrayInt(int length,int minValue = 0,int maxValue = 99){
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(minValue,maxValue+1);
            }
            return arr;
        }

        public static void LookArray(int[] arr){

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ ", ");
            }
            Console.WriteLine();
        }

    }
}