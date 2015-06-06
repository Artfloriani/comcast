using UnityEngine;
using System.Collections;

public class MovieStream : MonoBehaviour {

	public WWW wwwData;
	public string url = "http://www.dailymotion.com/swf/video/x2a2ti2";
	public GUITexture gt;
	void Start() {
		wwwData = new WWW(url);
		gt = GetComponent<GUITexture>();
		gt.texture = wwwData.movie;
	}
	void Update() {
		MovieTexture m = gt.texture as MovieTexture;
		if (!m.isPlaying && m.isReadyToPlay)
			m.Play();
		
	}
}
