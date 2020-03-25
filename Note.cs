using System;

namespace Laboratorijska_Vjezba1
{
    class Note
    {
        public enum Level
        {
            Low,
            Medium,
            High
        }
        protected String note
        {
            get { return this.note; }
            set { this.note = value; }
        }
        protected String author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        protected Level priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }
        public String getNote() { return this.note; }
        public String getAuthor() { return this.author; }
        public Level getPriority() { return this.priority; }
        public void setNote(String note) { this.note = note; }
        public void setPriority(Level priority) { this.priority = priority; }
        public override string ToString() { return this.note + "by" + this.author + "is of" + this.priority.ToString() + "priotity"; }
        public Note()
        {
            this.note = "null";
            this.priority = Level.Low;
            this.author = "nobody";
        }
        public Note(String note, String author, Level priority)
        {
            this.note = note;
            this.priority = priority;
            this.author = author;
        }
        public Note(String note, String author)
        {
            this.note = note;
            this.priority = Level.Low;
            this.author = author;
        }
        static void Main(string[] args)
        {
            Note test = new Note("Hello", "Vlatko");
            Console.WriteLine($"{test.getAuthor()} wrote {test.getNote()} ");
        }
    }
    class Notepad : Note
    {
        private DateTime timestamp;
        public Notepad(String note, String author, Level priority):base(note, author, priority) 
        {
            this.timestamp = DateTime.Now;
        }
        public Notepad(String note, String author) : base(note, author)
        {
            this.timestamp = DateTime.Now;
        }
        public Notepad():base()
        {
            this.timestamp = DateTime.Now;
        }
        public override string ToString() { return this.note + "by" + this.author + "is of" + this.priority.ToString() + "priotity" + "["+this.timestamp+"]"; }
    }
}
