using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resumes
{
    public class Resume
    {
        public string _personName;
        public List<Job> _jobs = new List<Job>();

        public void DisplayResume()
        {
            Console.WriteLine($"Name: {_personName}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.DisplayJobDetails();
            }
        }
    }
}