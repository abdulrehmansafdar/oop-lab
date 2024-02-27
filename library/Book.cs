namespace library
{
    internal class Book
    {

        private string Title;
        private Author author;
        private int Price;

        public Book(string title, int price, string authorName, string authorEmail)
        {
            Title = title;
            author = new Author(authorName, authorEmail);
            this.Price = price;
        }
        public void SetTitleBook(string title)
        {
            this.Title = title;
        }
        public void SetPriceBook(int price)
        {
            this.Price = price;
        }

        public string GetTitleBook()
        {
            return Title;
        }
        public int GetPriceBook()
        {
            return Price;
        }





    }
}
