using System;

public class Comment
{
    public string _name;
    public string _commentText;

        public Comment()
        {

        }

        public void DisplayCommentDetails()
        {
            Console.WriteLine($"Name: {_name}, Comment: {_commentText}");
            
        }

}