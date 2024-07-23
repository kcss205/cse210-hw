using System;

 public class Thought
    {
        public string Content { get; set; }

        public Thought(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }