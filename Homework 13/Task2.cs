using System;
using System.Collections.Generic;

public class EnglishFrenchDictionary
{
    private Dictionary<string, List<string>> dictionary;

    public EnglishFrenchDictionary()
    {
        dictionary = new Dictionary<string, List<string>>();
    }

    public void AddWord(string word, List<string> translations)
    {
        if (!dictionary.ContainsKey(word))
        {
            dictionary[word] = translations;
            Console.WriteLine($"Word '{word}' added.");
        }
        else
        {
            Console.WriteLine($"Word '{word}' already exists.");
        }
    }

    public void RemoveWord(string word)
    {
        if (dictionary.ContainsKey(word))
        {
            dictionary.Remove(word);
            Console.WriteLine($"Word '{word}' removed.");
        }
        else
        {
            Console.WriteLine($"Word '{word}' not found.");
        }
    }

    public void RemoveTranslation(string word, string translation)
    {
        if (dictionary.ContainsKey(word))
        {
            var translations = dictionary[word];
            if (translations.Remove(translation))
            {
                Console.WriteLine($"Translation '{translation}' for word '{word}' removed.");
            }
            else
            {
                Console.WriteLine($"Translation '{translation}' for word '{word}' not found.");
            }
        }
        else
        {
            Console.WriteLine($"Word '{word}' not found.");
        }
    }

    public void ChangeWord(string oldWord, string newWord)
    {
        if (dictionary.ContainsKey(oldWord))
        {
            var translations = dictionary[oldWord];
            dictionary.Remove(oldWord);
            dictionary[newWord] = translations;
            Console.WriteLine($"Word '{oldWord}' changed to '{newWord}'.");
        }
        else
        {
            Console.WriteLine($"Word '{oldWord}' not found.");
        }
    }

    public void ChangeTranslation(string word, string oldTranslation, string newTranslation)
    {
        if (dictionary.ContainsKey(word))
        {
            var translations = dictionary[word];
            int index = translations.IndexOf(oldTranslation);
            if (index != -1)
            {
                translations[index] = newTranslation;
                Console.WriteLine($"Translation '{oldTranslation}' for word '{word}' changed to '{newTranslation}'.");
            }
            else
            {
                Console.WriteLine($"Translation '{oldTranslation}' for word '{word}' not found.");
            }
        }
        else
        {
            Console.WriteLine($"Word '{word}' not found.");
        }
    }

    public void SearchTranslation(string word)
    {
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine($"Translations for '{word}':");
            foreach (var translation in dictionary[word])
            {
                Console.WriteLine(translation);
            }
        }
        else
        {
            Console.WriteLine($"Word '{word}' not found.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        EnglishFrenchDictionary dict = new EnglishFrenchDictionary();

        dict.AddWord("apple", new List<string> { "pomme", "fruit" });
        dict.AddWord("book", new List<string> { "livre" });

        dict.SearchTranslation("apple");

        dict.ChangeTranslation("apple", "fruit", "fruit de l'arbre");
        dict.RemoveTranslation("apple", "pomme");

        dict.ChangeWord("apple", "orange");
        dict.RemoveWord("book");
    }
}
