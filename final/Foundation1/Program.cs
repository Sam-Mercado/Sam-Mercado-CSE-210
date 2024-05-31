using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("THE WORLD OF ZOMBIES", "ZOMBIE BOI", 300);

        Comment comment1 = new Comment("LucasPro", "This video was just Hilarious ");

        Comment comment2 = new Comment("Pwdro", "Super usefull ");
        Comment comment3 = new Comment("AaronPlay", "Would this acually wrork? ");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);


        video1.DisplayVideo();


    }
}