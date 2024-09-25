namespace ConsoleApp16
{
    class Dict
    {
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            {"Желтый",  "Yellow"}, {"Синий", "Blue"}, {"Красный", "Red"}
        };

       
        public void addTranslate(string word, string translate)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, translate);
            }
          

            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

       
        public void removeWord(string word)
        {
            if (words.ContainsKey(word))
            {
                words.Remove(word);
            }
           

            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        
        public void removeTranslate(string word)
        {
            if (words.Remove(word))
            {
                Console.WriteLine($"Removed {word}.");
            }
           

            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

       
        public void changeTranslate(string key, string newTranslate)
        {
            if (words.ContainsKey(key))
            {
                words[key] = newTranslate; 
            }
          

            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

       
        public void searchTranslate(string key)
        {
            if (words.TryGetValue(key, out string value))
            {
                Console.WriteLine($"{key}: {value}");
            }
           
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dict obj = new Dict();
            obj.addTranslate("Фиолетовый", "Purple");  
            obj.removeTranslate("Красный");  
            obj.changeTranslate("Синий", "White");  
            obj.searchTranslate("Желтый");  
        }
    }
}

