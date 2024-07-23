using System;

    public class Progress
    {
        public int PagesRead { get; set; }
        public int TotalPages { get; set; }

        public Progress()
        {
            PagesRead = 0;
            TotalPages = 0;
        }

        public override string ToString()
        {
            return $"{PagesRead}/{TotalPages} pages read";
        }
    }