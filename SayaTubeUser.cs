using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string username;

	public SayaTubeUser(string username)
	{
		Debug.Assert(username != null);
		Debug.Assert(username.Length < 100);
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
		Debug.Assert(video != null);
		Debug.Assert(video.getPlayCount() <= 1000000000000);
		uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlaycount()
	{
		Console.WriteLine("User: {0:s}", username);
		for(int i=0;i<uploadedVideos.Count && i < 8; i++ )
		{
			Console.WriteLine("Video {0:d} judul: {1:s}", i + 1, uploadedVideos[i].getTitle());
			
		}
	}
}
