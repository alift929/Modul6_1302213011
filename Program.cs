// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Alif");
        SayaTubeVideo v1 = new SayaTubeVideo("Review film Harry Potter oleh Alif");
        v1.IncreasePlayCount(5);
        SayaTubeVideo v2 = new SayaTubeVideo("Review film Lord of The Rings oleh Alif");
        v2.IncreasePlayCount(10);
        SayaTubeVideo v3 = new SayaTubeVideo("Review film Iron Man oleh Alif");
        v3.IncreasePlayCount(3);
        SayaTubeVideo v4 = new SayaTubeVideo("Review film Spider Man oleh Alif");
        v4.IncreasePlayCount(6);
        SayaTubeVideo v5 = new SayaTubeVideo("Review film Deadpool oleh Alif");
        v5.IncreasePlayCount(7);
        SayaTubeVideo v6 = new SayaTubeVideo("Review film Multiverse oleh Alif");
        v6.IncreasePlayCount(4);
        SayaTubeVideo v7 = new SayaTubeVideo("Review film Endgame oleh Alif");
        v7.IncreasePlayCount(5);
        SayaTubeVideo v8 = new SayaTubeVideo("Review film I'm Groot oleh Alif");
        v8.IncreasePlayCount(9);
        SayaTubeVideo v9 = new SayaTubeVideo("Review film Loki oleh Alif");
        v9.IncreasePlayCount(1);
        SayaTubeVideo v10 = new SayaTubeVideo("Review film Captain America oleh Alif");
        v10.IncreasePlayCount(2);

        user.AddVideo(v1);
        user.AddVideo(v2);
        user.AddVideo(v3);
        user.AddVideo(v4);
        user.AddVideo(v5);
        user.AddVideo(v6);
        user.AddVideo(v7);
        user.AddVideo(v8);
        user.AddVideo(v9);
        user.AddVideo(v10);

        user.PrintAllVideoPlaycount();

        Console.WriteLine("\nTotal PlayCount: {0:d}", user.GetTotalVideoPlayCount());
    }
}
