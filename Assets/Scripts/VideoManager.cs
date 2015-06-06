using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VideoManager : MonoBehaviour {

	public GameObject[] videos;

	public List<string> videoNames;

	int index = 0;
	// Use this for initialization
	void Start () {
		videoNames = new List<string> ();
		videoNames.Add ("blue-480x256-divx.avi.bin");
		videoNames.Add ("green-480x256-divx.avi.bin");
		videoNames.Add ("purple-480x256-divx.avi.bin");
		videoNames.Add ("yellow-480x256-divx.avi.bin");


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playVideo(int id){
		AVProWindowsMediaMovie mediaMovie = videos [id].GetComponent<AVProWindowsMediaMovie> ();
		mediaMovie._filename = videoNames [index++];
		index = index % videoNames.Count;
		mediaMovie.LoadMovie (true);
		mediaMovie._volume = 1.0f;
		mediaMovie._useAudioMixer = true;
		
		mediaMovie.Play ();


	}

	public void stopVideo(int id){
		//AVProWindowsMediaMaterialApply apply = videos [id].GetComponent<AVProWindowsMediaMaterialApply> ();
		AVProWindowsMediaMovie mediaMovie = videos [id].GetComponent<AVProWindowsMediaMovie> ();
		mediaMovie.Pause ();
		//apply.enabled = false;
	}
}
