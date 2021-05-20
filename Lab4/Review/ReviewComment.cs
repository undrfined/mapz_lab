using System;

namespace Lab4.Review
{
    public class ReviewComment : ReviewComponent
    {
        public ReviewComment(Guid authorId, string text) : base(authorId, text)
        {
        }

        public override void Display(int padding = 0)
        {
            for (var i = 0; i < padding; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine(AuthorId + ": " + Text);
        }

        public override void Add(ReviewComponent c)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(ReviewComponent c)
        {
            throw new System.NotImplementedException();
        }
    }
}