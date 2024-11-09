namespace DsaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter itm aary");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            for (int i=0; i< arr.Length;i++)
                {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
