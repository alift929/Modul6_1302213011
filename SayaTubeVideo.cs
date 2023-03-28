using System;
using System.Diagnostics;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo(string judul)
	{
		Debug.Assert(judul != null);
		Debug.Assert(judul.Length <= 200);
		var random = new Random();
		id = random.Next(10000, 99999);
		title = judul;
		playCount = 0;
	}

	public void IncreasePlayCount(int play)
	{
		Debug.Assert(play <= 25000000);
		Debug.Assert(play >= 0);
		try
		{
			int check = checked(playCount += play);
			playCount += check;
		}
		catch (OverflowException e)
		{
			Console.WriteLine("Overflow Exception: " + e.Message);
		}
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
