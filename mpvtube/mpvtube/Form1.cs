using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;


namespace mpvtube
{
	public partial class Form1 : Form
	{
		public List<string> urls;

		public const string MpvRoot = "mpv";
		public const string QualRoot = "ytdl-format=";

		public const string QualBest = "best";
		public const string QualLow = "\"best[height=360]\"";
		public const string QualAudio = "bestaudio";

		public const string MPVLow = "vo=opengl:deband hwdec=auto";
		public const string MPVMedium = "vo=opengl-hq hwdec=auto";
		public const string MPVHigh = "vo=opengl-hq:scale=ewa_lanczossharp:cscale=ewa_lanczossoft hwdec=auto";
		public const string MPVHighest = "vo=opengl-hq:scale=ewa_lanczossharp:cscale=ewa_lanczossoft:prescale-luma=superxbr:prescale-downscaling-threshold=1.5";
		public const string MPVInsane = "vo=opengl-hq:scale=ewa_lanczossharp:cscale=ewa_lanczossoft:prescale-luma=nnedi3:prescale-downscaling-threshold=1.5";

		public Form1 ()
		{
			InitializeComponent();
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			highQuality.Checked = true;
			mpvHigh.Checked = true;
		}

		private async void searchBtn_Click (object sender, EventArgs e)
		{
			resultsList.Items.Clear();
			try
			{
				urls.Clear();
			}
			catch { }
			var youtubeService = new YouTubeService(new BaseClientService.Initializer()
			{
				ApiKey = Properties.Resources.ApiKey.ToString(),
				ApplicationName = this.GetType().ToString()
			});

			var searchListRequest = youtubeService.Search.List("snippet");
			searchListRequest.Q = searchTxt.Text;
			searchListRequest.MaxResults = 50;

			var searchListResponse = await searchListRequest.ExecuteAsync();

			urls = new List<string>();

			foreach (var searchResult in searchListResponse.Items)
			{
				if (Equals(searchResult.Id.Kind, "youtube#video"))
				{
					urls.Add(searchResult.Id.VideoId);

					ListViewItem itemToAdd = new ListViewItem();
					itemToAdd.Text = searchResult.Snippet.Title;
					itemToAdd.SubItems.Add(new ListViewItem.ListViewSubItem(itemToAdd, searchResult.Snippet.ChannelTitle));
					itemToAdd.SubItems.Add(new ListViewItem.ListViewSubItem(itemToAdd, searchResult.Snippet.PublishedAt.ToString()));
					itemToAdd.SubItems.Add(new ListViewItem.ListViewSubItem(itemToAdd, searchResult.Snippet.Description));
					resultsList.Items.Add(itemToAdd);
				}
			}
		}

		private void playVideo(string url, string ytquality, string mpvquality)
		{
			if (alwaysOnTopToolStripMenuItem.Checked)
				ytquality = ytquality + " --ontop";
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/K mpv https://www.youtube.com/watch?v=" + url + " --ytdl-format=" + ytquality + " " + mpvquality;
			Console.Write(startInfo.Arguments);
			process.StartInfo = startInfo;
			process.Start();
			if (closeAfterStartingVideoToolStripMenuItem.Checked)
				Application.Exit();
		}

		private void playBtn_Click (object sender, EventArgs e)
		{
			resultsList_DoubleClick(sender, e);
		}

		private void resultsList_DoubleClick (object sender, EventArgs e)
		{
			string ytQual = "";
			string mpvQual = "";
			if (highQuality.Checked)
				ytQual = QualBest;
			else if (lowQuality.Checked)
				ytQual = QualLow;
			else if (audioQuality.Checked)
				ytQual = QualAudio;

			if (mpvLow.Checked)
				mpvQual = MPVLow;
			else if (mpvMedium.Checked)
				mpvQual = MPVMedium;
			else if (mpvHigh.Checked)
				mpvQual = MPVHigh;
			else if (mpvHighest.Checked)
				mpvQual = MPVHighest;
			else if (mpvInsane.Checked)
				mpvQual = MPVInsane;

			playVideo(urls[resultsList.FocusedItem.Index], ytQual, mpvQual);
		}

		private void resultsList_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (resultsList.SelectedItems != null)
				playBtn.Enabled = true;
			else
				playBtn.Enabled = false;
		}
	}
}
