using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 新闻系统存储过程.Models
{
    public class NewsInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string cclass;

        public string Cclass
        {
            get { return cclass; }
            set { cclass = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string datetime;

        public string Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}