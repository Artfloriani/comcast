using UnityEngine;
using System.Collections;

public class RandomScript : MonoBehaviour {
	
	
	GameObject cube;

	public VideoManager videos;
	
	public int id;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public int enterLook(){
		print ("ENTER " + id);
		videos.playVideo (id);

		return id;
	}
	
	public void exitLook(){
		videos.stopVideo (id);
		print ("EXIT " + id);
	}
}
