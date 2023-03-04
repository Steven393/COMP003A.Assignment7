/*
* Author: Steven Gonzalez
* Course: COMP-003A
* Purpose: Array and List
* 
*/

using System;
using System.Collections.Generic;

class Program
{
    static void SectionSeparator(string sectionName)
    {
        Console.WriteLine(new string('*', 50));
        Console.WriteLine(sectionName);
        Console.WriteLine(new string('*', 50));
    }
    
    static int CharacterCounter(char characterInput, string word)
    {
        int counter = 0;
        string lowerWord = word.ToLower();
        char lowerCharacterInput = Char.ToLower(characterInput);
        foreach (char character in lowerWord)
        {
            if (character == lowerCharacterInput)
            {
                counter++;
            }
        }
        return counter;
    }

    static bool IsPalindrome(string word)
    {
        string reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return reversedWord.ToLower() == word.ToLower();
    }

    static void TraverseList(List<string> list)
    {
        
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void TraverseListReverse(List<string> list)
    {
       
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }

    static void Main()
    {
        // Array - CharacterCounter Section
        SectionSeparator("Array - CharacterCounter Section");
        Console.Write("Please enter a letter: ");
        char letter = Console.ReadLine()[0];
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        int count = CharacterCounter(letter, word);
       
        Console.WriteLine("There are " + count +" letter " + letter + " in the word " +word);

        // Array - IsPalindrome Section
        SectionSeparator("Array - IsPalindrome Section");
        Console.Write("Please enter a word to check if it is a palindrome Racar: ");
        string palindromeCheck = Console.ReadLine();
        bool isPalindrome = IsPalindrome(palindromeCheck);
        Console.WriteLine("\nIs the word Racecar Palindrome: " + isPalindrome);

        // List - Add Section
        SectionSeparator("List - Add Section");
        List<string> names = new List<string>();
        string userInput = "";
        do
        {
            Console.Write("Please enter a name to add to the list: ");
            string name = Console.ReadLine();
            names.Add(name);

            Console.Write("Press any key to add more or (e) to exit.");
            userInput = Console.ReadLine();
        } while (userInput != "e");


        // List - Traversal Section
        SectionSeparator("List - Traversal Section");
        TraverseList(names);

        // List - Reverse Traversal Section
        SectionSeparator("List - Reverse Traversal Section");
        TraverseListReverse(names);

        Console.ReadLine();
    }
}