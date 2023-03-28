using System;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo(string judul)
	{
		var random = new Random();
		id = random.Next(10000, 99999);
		title = judul;
		playCount = 0;
	}

	public void IncreasePlayCount(int play)
	{
		playCount += play;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("Id: {0:d}\nTitle: {1:s}\nPlayCount: {2:d}",id,title,playCount);
	}

	public int getPlayCount()
	{
		return playCount;
	}

	public string getTitle()
	{
		return title;
	}
}
