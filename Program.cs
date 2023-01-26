namespace NewAppMetodZ2
{
    internal class Program
    {

        /// <summary>
        /// Ввод строки в консоль
        /// </summary>
        static string InString()
        {
            string str = Console.ReadLine();

            return str;
        }
        

        /// <summary>
        /// Находим строку с минимальным количеством символов
        /// </summary>
        /// <param name="strA"> новый массив который состоял из строки </param>
        /// <param name="strB"> массив для сохранения найденного минимального значения </param>
        static void FindMin(string[] strA, string[] strB)
        {
            for (int i = 0; i < strA.Length; i++)
            {
                if ($"{strA[i]}".Length < $"{strB[0]}".Length)
                {
                    strB[0] = strA[i];
                }
            }
        }

        /// <summary>
        /// Вывод  масива с мин кол-вом символов
        /// </summary>
        /// <param name="Min"> найденный массив </param>
        static void OutMin(string [] Min)
        {
            Console.WriteLine($"Ответ: {Min[0]}");
        }



        

        /// <summary>
        /// Находим строку с максимальным количеством символов
        /// </summary>
        /// <param name="MaxData"> новый массив который состоял из строки </param>
        /// <param name="StrMax"> строка для сохранения найденного максимального значения </param>
        static string FindMax(string[] MaxData, string StrMax)
        {

            for (int i = 0; i < MaxData.Length; i++)
            {

                if (MaxData[i].Length > StrMax.Length)
                {
                    StrMax = MaxData[i];
                }
            }
            return StrMax;
        }


        /// <summary>
        /// Вывод всех массивов с максимальным кол-вом символов 
        /// </summary>
        /// <param name="StrMax"> Макссимальное число символов </param>
        /// <param name="MaxData"> Массив в котором ищем </param>
        static void OutMax (string [] MaxData, string StrMax)
        {
            for (int i = 0; i < MaxData.Length; i++)
            {
                if (StrMax.Length == MaxData[i].Length) Console.Write($"{MaxData[i]}   ");
            }
        }

        static void Main(string[] args)
        {

            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД


            Console.WriteLine("Введи строку с символами ");
            string data = InString();

            string[] MinData = data.Split(' ',',','.');  // Разбивает строку на массив с задаными разделителями

            string [] StrMin = MinData;            

            FindMin(MinData, StrMin);

            OutMin(StrMin);


            string[] MaxData = data.Split(' ', ',', '.');
            string StrMax = MaxData[0];

            var Res = FindMax(MaxData, StrMax);

            OutMax(MaxData, Res);

            //for (int i = 0; i < MinData.Length; i++)
            //{                
            //    if ($"{MinData[i]}".Length < $"{StrMin}".Length)
            //    {
            //         StrMin = MinData[i];
            //    }                
            //}
            //Console.WriteLine($"Ответ: {StrMin}");



            //for (int i = 0; i < MaxData.Length; i++)
            //{
            //    if (MaxData[i].Length > StrMax.Length)
            //    {
            //        StrMax = MaxData[i];
            //    }
            //}
            //for (int i = 0; i < MaxData.Length; i++)
            //{
            //    if (StrMax.Length == MaxData[i].Length) Console.Write($"{MaxData[i]}   ");
            //}

        }
    }
}