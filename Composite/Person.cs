using System;

namespace Composite
{
    public class Person:INode
    {
        private int _score;
        public string Name { get; set; }
        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                Console.WriteLine($"{Name}--->>Score{_score}");
            }
        }
    }
}