namespace Цезарь
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово,которое нужно зашифровать:");
            string s = Console.ReadLine();
            string abc = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";       
            Console.WriteLine("Укажите длину сдвига");
            int len = Convert.ToInt32(Console.ReadLine());
            int a;
            string code = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int pos;
                char c = s[i];
                pos = abc.IndexOf(c);
                a = pos + len;
                if (a > 32) a -= 33;
                code += abc[a];
            }
            Console.WriteLine(code);
            Console.ReadLine();
        }
    }
}
