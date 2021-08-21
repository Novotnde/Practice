using System;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var postService = new PostService();
            var posted = postService.PostAnIssue();
            Console.Clear();
            Console.WriteLine("Your post : \n {0} \n {1} . \n created : {2}" ,posted.Title, posted.Description, posted.Creation  );
           
            Console.WriteLine("Do you with to rate this post? Please type in 'up' to Like or 'down' to Dislike and 'exit' if you wish to leave");
            var userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "up":
                    postService.VoteUp(posted);
                    break;
                case "down":
                    postService.VoteDown(posted);
                    break;
                case "exit":
                    break;
                    default:
                        throw new InvalidOperationException();
                
            }
            Console.WriteLine("Post {0} now has {1} votes", posted.Title, posted.Vote);
            Console.WriteLine("Thank you");
          
        }
    }
    
}