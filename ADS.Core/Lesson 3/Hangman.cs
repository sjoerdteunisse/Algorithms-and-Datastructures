using System;
using System.IO;
using System.Collections.Generic;

namespace ADS.Core.Lesson_3
{
    public class Hangman
    {
        private Random _rnd;
        private int _wordCount;
        private int _guessWordPos;
        private StreamReader _file;
        private List<string> _lines;

        public Hangman()
        {
            _rnd = new Random();
            _lines = new List<string>();
            _file = new StreamReader(@Directory.GetCurrentDirectory() + "\\Lesson 3\\hangman.txt");
            _wordCount = 0;
            FillList();
        }

        public void FillList()
        {
            string line;

            while ((line = _file.ReadLine()) != null)
            {
                _lines.Add(line);
                _wordCount++;
            }
        }

        public void ChooseWord()
        {
            _lines.RemoveAt(_guessWordPos);
            _wordCount--;

            if (_lines.Count > 0)
            {
                _guessWordPos = _rnd.Next(0, _wordCount);
                Console.WriteLine(_lines[_guessWordPos]);
            }
            else
            {
                Console.WriteLine("congratz, you've played all words. Or the file is empty");
            }
        }

        public void GuessWord(string word)
        {
            if (_lines.Count == 0)
            {
                return;
            }

            if (_lines[_guessWordPos] == word)
            {
                Console.WriteLine("Correct!");
                
                ChooseWord();
            }
            else
            {
                Console.WriteLine("Wrong awnser");
            }
        }
    }
}