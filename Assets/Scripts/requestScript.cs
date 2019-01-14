using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class requestScript : MonoBehaviour {

	private const string URL = "http://www.omdbapi.com/?t=";
	private const string TOKEN = "&apikey=trilogy";
	public InputField movieNameinput;
	public string movieName;

	public Text ResponseText;
	


	public void Request() {
		
		Debug.Log("url string:"+URL+movieNameinput.text+TOKEN);
		WWW request = new WWW(URL+movieNameinput.text+TOKEN);
		StartCoroutine(OnResponse(request));
	}
	private IEnumerator OnResponse(WWW req){
		yield return req;
		Debug.Log("REq:"+ req.text);
		ResponseText.text = req.text;
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}