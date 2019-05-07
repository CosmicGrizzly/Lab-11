using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string title;
        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        private string category;
        public string Category
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }
        public Movie(string _title,string _category)
        {
            Title = _title;
            Category = _category;
        }
    }
}
