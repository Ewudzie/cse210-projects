using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        VideoEntry videoEntry1 = new VideoEntry();
        videoEntry1._videoTitle = "Red Sea";
        videoEntry1._videoAuthor = "Chris Rocks";
        videoEntry1._videoLenght = 1333;

        //videoEntry1._videoComment = "This is an awesome video";

        VideoEntry videoEntry2= new VideoEntry();
        videoEntry2._videoTitle = "Ribbinson Family";
        videoEntry1._videoAuthor = "Derrick Path";
        videoEntry1._videoLenght = 1563;

        VideoEntry videoEntry3 = new VideoEntry();
        videoEntry3._videoTitle = "The Rails";
        videoEntry3._videoAuthor = "Jonas Moon";
        videoEntry3._videoLenght = 16233;

        videoEntry1.DisplayVideoDetails();
        videoEntry2.DisplayVideoDetails();
        videoEntry3.DisplayVideoDetails();

        Comment myComment = new Comment();
        myComment._name = "Josh Bryan";
        myComment._commentText = "This is an awesome video";
        myComment.DisplayCommentDetails();
        

       // videoEntry1._videoComment.Add()


        
    }
}