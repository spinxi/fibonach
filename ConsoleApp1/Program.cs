namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            /*int[] arr = FibonachiLoop(9);*/
            
            /*FibRecursion(9);*/
            Sorting();
            
        }

        public static void Sorting()
        {
            int[] array = new int[10];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(10);
            }
        
            bool check_num = true;
            while (check_num)
            {
                check_num = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i+1];
                        array[i + 1] = temp;
                        check_num = true;
                    }
                }   
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array Numbers: {array[i]}");
            }
        }

        public static int[] FibonachiLoop(int num)
        {
            int[] fibNums = new int[num];
            
            int firstNum = 0;
            int secondNum = 1;
            
            fibNums[0] = firstNum;
            fibNums[1] = secondNum;
            
            for (int i = 2; i < num; i++)
            {
                fibNums[i] = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = fibNums[i];
            }

            return fibNums;
        }
        
        public static int FibRecursion(int num)
        {
            if (num < 1)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            return (FibRecursion(num-1)+FibRecursion(num-2));
        }
    }
}