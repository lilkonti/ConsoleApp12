namespace ConsoleApp12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            void show(int len, char chr)
            {
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        Console.Write(chr);
                    }
                    Console.Write("\n");
                }
            }
            void palindrom(string str)
            {
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string rev = new string(arr);
                if (rev == str) Console.WriteLine("Palindrom - " + str);
                else Console.WriteLine("Not palindrom - " + str);
            }

            int[] filter(int len_original, int len_filter, int[] arr_original, int[] arr_filter)
            {
                int[] new_arr = new int[4];
                int iter = 0;
                for (int j = 0; j < len_original; j++)
                {
                    if (arr_original[j] != arr_filter[0])
                    {
                        new_arr[iter] = arr_original[j];
                        ++iter;
                    }
                }
                return new_arr;
            }

            show(5, 'c');
            Console.WriteLine();

            palindrom("GoG");
            palindrom("fari");
            Console.WriteLine();

            int[] arr = { 5, 5, 5, 3, 5};
            int[] arr1 = { 3, 2, 1};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            int[] arr_fil = filter(5, 2, arr, arr1);
            for (int i = 0;i < arr_fil.Length;i++) 
            {
                Console.WriteLine(arr_fil[i]);
            }
        }
    }
}