using UnityEngine;
using System.Collections;

public class VideoActivateScript : MonoBehaviour {

	public GameObject[] videoFrames; 

	public float[] videoAngles;

	public int activatedVideo;

	public int angleTolerance = 45;
	

	private Vector3 referenceVector;


	

	// Use this for initialization
	void Start () {


		activatedVideo = 0;
		RandomScript script = videoFrames[0].GetComponent<RandomScript>();
		script.enterLook ();



	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		Vector3 cameraCenter = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, GetComponent<Camera>().nearClipPlane));
		if (Physics.Raycast(cameraCenter, this.transform.forward, out hit, 1000))
		{
			GameObject obj = hit.transform.gameObject;
			RandomScript script = obj.GetComponent<RandomScript>();
			if(script != null && obj != videoFrames[activatedVideo]){
				int id = script.enterLook();
				RandomScript activatedScript = videoFrames[activatedVideo].GetComponent<RandomScript>();
				activatedScript.exitLook();
				activatedVideo = id;
			}	
		}



		
					               
	}
	
}
