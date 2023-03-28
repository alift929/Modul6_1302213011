// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Alif");
        SayaTubeVideo v1 = new SayaTubeVideo("Review film Harry Potter oleh Alif");
        SayaTubeVideo v2 = new SayaTubeVideo("Review film Lord of The Rings oleh Alif");
        SayaTubeVideo v3 = new SayaTubeVideo("Review film Iron Man oleh Alif");
        SayaTubeVideo v4 = new SayaTubeVideo("Review film Spider Man oleh Alif");
        SayaTubeVideo v5 = new SayaTubeVideo("Review film Deadpool oleh Alif");
        SayaTubeVideo v6 = new SayaTubeVideo("Review film Multiverse oleh Alif");
        SayaTubeVideo v7 = new SayaTubeVideo("Review film Endgame oleh Alif");
        SayaTubeVideo v8 = new SayaTubeVideo("Review film I'm Groot oleh Alif");
        SayaTubeVideo v9 = new SayaTubeVideo("Review film Loki oleh Alif");
        SayaTubeVideo v10 = new SayaTubeVideo("Review film Captain America oleh Alif");

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
    }
}
