using OOP_Assignment3.Model._5__Task_Tracker_Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._5__Task_Tracker_Application
{
    public class Task_Track
    {
        public Task_Track(string title, string description, TaskPriority priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = false;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public bool IsCompleted { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nPriority: {Priority}\nCompleted: {IsCompleted}\n----------";
        }
    }
}
