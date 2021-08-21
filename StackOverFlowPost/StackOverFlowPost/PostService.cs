using System;

namespace StackOverFlowPost
{
    public class PostService
    {
        private Post CreateAnIssue()
        {
            var post = new Post();
            Console.WriteLine("What is the title of your post");
            post.Title = Console.ReadLine();
            Console.WriteLine("Please describe your issue");
            post.Description = Console.ReadLine();
            post.Creation = DateTime.Now;
            return post;
        }

        public Post PostAnIssue()
        {
            var post = CreateAnIssue();
            return post;
        }
        

        public void VoteDown(Post post)
        { 
            post.Vote--;
        }
        
        public void VoteUp(Post post)
        {
            post.Vote++;
        }
    }
}