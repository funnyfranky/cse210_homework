using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];
        Video video1 = new("Never Talk to Strangers","Daily Dose Of Internet",513);
        video1.AddComment("DanielLopez-he4nq","\"for some reason this panda is an absolute freak\"");
        video1.AddComment("boseo1314","I always appreciate that your thumbnails are always the first video.");
        video1.AddComment("VirtualRiot","Oooooh (6:01) so THATS why they're called Ducks");
        video1.AddComment("OffensiveFarmer","I am 100% refusing to give money to any business that uses AI camera tracking for customers and their employees. Feels like it should be a legal requirement to disclose they're doing that [stuff].");
        video1.AddComment("Keksemann667","The Garbage guys are required to not take out a bin that got tossed in, they can get seriously hurt, they are required to leave it in and document which house the bin belongs to, they will bring a new one within the next few days or some disposal companies wait till they get called and then they tell you where you can get a new one or that you should buy a new one and mail them the receipt (they usually deduct it from the garbage payment of the next month(s) in that case)");
        videos.Add(video1);

        Video video2 = new("25 Missing Kids Discovered Behind Secret Door","EWU Bodycam",2061);
        video2.AddComment("DutchFurnace","ALL of those women involved should be in jail for a long time. If I'm being told to hide children in a basement behind a secret door I'm calling the police right away.");
        video2.AddComment("PewdieTalia4Ever","The way she's giggling and gaslighting the cops is SO eerie. Something is so wrong with this woman and I hope she's never in charge of children ever again. Her lights aren't on upstairs and I'm surprised at how long the cops were friendly with her.");
        video2.AddComment("rocktheboat56","I'm a construction worker, i spend a lot of time staring at how things are built and put together. It's absolutely INSANE how that officer was able to spot that gap in the corner where the basement door was");
        video2.AddComment("Kells_Kells","Holy [crap], this is the daycare I looked into to bring my 4 month old to! I had a phone interview with her and was supposed to go meet her the next day, but decided against it BECAUSE she would not tell me the number of smaller children she had. Something didn't sit right with me, and being a first-time mom and already anxious about dropping my baby off, I decided to look into actual daycare centers. When this all came out, I literally cried my eyes out! Those poor children");
        videos.Add(video2);

        Video video3 = new("Here's Why You Don't Punch a Cop","Midwest Safety",1197);
        video3.AddComment("ChrisPernaDrums","This dude is definitely a kid who ate glue in kindergarten.");
        video3.AddComment("knightsofneeech","People like this are why body cameras are necessary.");
        video3.AddComment("Xdenomic","\"that's police brutality\"\n\"I'm sorry you feel that way\"\nGolden");
        videos.Add(video3);


        Video video4 = new("Most Viewed Courtroom Moments Of ALL TIME","Courtroom",1736);
        video4.AddComment("General_Mahacdonalds","I almost cried when watching the second guy. So happy to see that he is free of charge. Hope he enjoys the rest of his life with his family");
        video4.AddComment("jimwheeler4770","Any cop who coerces a false confession should spend the equal amount of time in jail.");
        video4.AddComment("pamelaibarra790","I teared up with daniel villegas. That cop that forced a confession should have to serve AT LEAST 18 years. He took those years away from a child because he was too lazy to do his job. Take the same from him.");
        video4.AddComment("daviddobinson188","The irony of matey saying \"I do what I wanna do\"\nEnjoy the rest of your life being told when to eat, exercise and speak");
        videos.Add(video4);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}