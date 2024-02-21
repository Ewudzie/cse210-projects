using System;
using System.Transactions;

public class VideoEntry
{
    public string _videoTitle = "";
    public string _videoAuthor = "";
    public int _videoLenght;
    public List<Comment>_videoComment = new List<Comment>();

    public VideoEntry ()
    {

    }

        public void DisplayVideoDetails()
        {
            Console.WriteLine($"{_videoTitle}, {_videoAuthor}, {_videoLenght}sec, {_videoComment}");
            foreach (Comment comment in _videoComment)
            {
                comment.DisplayCommentDetails();
            }

        }



}