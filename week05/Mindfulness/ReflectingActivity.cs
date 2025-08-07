using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity(string name, string description) : base(name, description)
        {
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }
// me quede en agregar elementos a las listas _prompts y _questions. Ahora deberia comenzar a
// crear los demas metodos de la clase y luego integrarlos al metodo Run() 
        public void Run()
        {
            DisplayStartingMessage();

            DisplayEndingMessage();
        }
    }
}