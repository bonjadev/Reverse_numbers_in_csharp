namespace c__Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide input number: ");
            int input = int.Parse(Console.ReadLine()); //konverzija u integer i citanje te vrednosti u promenjivoj int

            int remainder, reverse = 0;
            while (input > 0) //ispitivanje uslova 
            {
                remainder = input % 10;
                reverse = reverse * 10 + remainder;
                input = input / 10;
            }
            Console.WriteLine($"reverse number is {reverse}"); //ispisivanje vrednost na mesto placeholdera koji je oznacen sa {}
        }
    }
}