namespace _06_practice_1
{
    class Stat
    {
        public static int Words;
        public static int Lines;
        public static int Punctuation;
    }
    class Program
    {
        static readonly char[] PunctuationMarks =
            { '.', ',', ';', ':', '–', '—', '‒', '…', '!', '?', '"', '\'', '«', '»', '(', ')', '{', '}', '[', ']', '<', '>', '/' };
        static void Main(string[] args)
        {
            /*Завдання 1:
Створити програму для аналізу текстових файлів в певній директорії.
Додаток повинен визначити:
• кількість слів в файлі
• к-сть рядків
• к-сть розділових знаків (. , ; : – — ‒ … ! ? "" '' «» () {} [] <> /)
Аналіз кожного файла виконати в окремому потоці. Кожний потік повинен записувати результат в клас, який містить властивості (Words, Lines, Punctuation) для збереження загальної к-сті знайдених елементів.
Для спільного доступа до властивостей, використайте об’єкти синхронізації (Interlocked, Monitor).
 */
            string[] files = Directory.GetFiles(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Test");
            Thread[] threads = new Thread[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                string text = File.ReadAllText(files[i]);
                threads[i] = new Thread(TextAnalyse!);
                threads[i].Start(text);
            }
            foreach (var thread in threads)
                thread.Join();

            Console.WriteLine($"total words: {Stat.Words}");
            Console.WriteLine($"total lines: {Stat.Lines}");
            Console.WriteLine($"total punctuation marks: {Stat.Punctuation}");
        }
        static void TextAnalyse(object textObj)
        {
            string text = textObj as string ?? string.Empty;
            int wordCount = text.Split([' ', '\r', '\n', '\t'], StringSplitOptions.RemoveEmptyEntries).Length;
            int lineCount = text.Split('\n').Length;
            int punctuationCount = 0;
            foreach (char c in text)
            {
                if (Array.IndexOf(PunctuationMarks, c) >= 0)
                    punctuationCount++;
            }
            Interlocked.Add(ref Stat.Words, wordCount);
            Interlocked.Add(ref Stat.Lines, lineCount);
            Interlocked.Add(ref Stat.Punctuation, punctuationCount);
        }
    }
}