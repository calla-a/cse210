using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class PrompGenerator
    {
        public List<string> _prompts = new List<string>();

        public void AddPrompt()
        {
            _prompts.Add("If you could go back in time to an exact moment today, which one would it be?");
            _prompts.Add("What happened today that you would like to see happen again in the future?");
            _prompts.Add("What made you laugh today?");
            _prompts.Add("Did you have any interesting conversations today?");
            _prompts.Add("Were you happy to see someone today?");
            _prompts.Add("Do you think today was a tiring day?");
            _prompts.Add("Did you do something today that you think you could have done better?");
            _prompts.Add("Did you see any family members today?");
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(_prompts.Count);
            return _prompts[randomIndex];
        }
    }
}