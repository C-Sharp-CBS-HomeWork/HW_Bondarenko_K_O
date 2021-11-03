namespace Task_13_3
{
    class Book
    {
        Title title;
        Content content;
        Author author;
        
        public Book(string title, string content, string author)
        {
            this.title = new Title(title);
            this.content = new Content(content);
            this.author = new Author(author);
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }        
    }
}
