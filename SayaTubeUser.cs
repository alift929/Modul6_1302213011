using System;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string username;

	public SayaTubeUser(string username)
	{
		this.username = username;
		this.uploadedVideos= new List<SayaTubeVideo>();
	}

	public int GetTotalVideoPlayCount()
	{
		int total=0;
		for(int i=0;i<uploadedVideos.Count;i++)
		{
			total += uploadedVideos[i].getPlayCount();
		}
		return total;
	}

	public void AddVideo(SayaTubeVideo video)
	{
		uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlaycount()
	{
		Console.WriteLine("User: {0:s}", username);
		for(int i=0;i<uploadedVideos.Count;i++)
		{
			Console.WriteLine("Video {0:d} judul: {1:s}", i + 1, uploadedVideos[i].getTitle());
		}
	}
}
