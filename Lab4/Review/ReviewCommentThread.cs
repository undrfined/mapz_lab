using System;
using System.Collections.Generic;

namespace Lab4.Review
{
    public class ReviewCommentThread : ReviewComponent
    {
        private readonly List<ReviewComponent> _children = new();

        public ReviewCommentThread(Guid authorId, string text) : base(authorId, text)
        {
        }

        public override void Display(int padding = 0)
        {
            for (var i = 0; i < padding; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("[Thread] " + AuthorId + ": " + Text);
 
            foreach (var component in _children)
            {
                component.Display(padding + 1);
            }
        }

        public override void Add(ReviewComponent c)
        {
            _children.Add(c);
        }

        public override void Remove(ReviewComponent c)
        {
            _children.Remove(c);
        }
    }
}