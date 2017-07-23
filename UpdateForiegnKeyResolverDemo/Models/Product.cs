namespace UpdateForiegnKeyResolverDemo.Models
{
    public class Product
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

        private int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        private Category category;

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}