using System;

namespace Lab4.Review
{
    public abstract class ReviewComponent
    {
        protected Guid AuthorId;
        protected string Text;
 
        public ReviewComponent(Guid authorId, string text)
        {
            AuthorId = authorId;
            Text = text;
        }
 
        public abstract void Display(int padding = 0);
        public abstract void Add(ReviewComponent c); 
        public abstract void Remove(ReviewComponent c);
    }
}