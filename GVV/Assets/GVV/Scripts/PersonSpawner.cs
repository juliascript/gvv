using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour {

	public GameObject person;
	string url = "https://gvv-api.herokuapp.com/scrape-date";


	// Use this for initialization
	void Start () {
		StartCoroutine(MakeAPIRequest());
		print ("API request being made");
		GameObject p = Instantiate (person);
		Vector3 pos = new Vector3(1, 0, 1); 
		p.transform.position = pos;
	}

	IEnumerator MakeAPIRequest ()
	{
		print ("hello");
		WWW www = new WWW(url);
		yield return www;
		print ("API request dinished");

		// TODO: parse json into Person class/some object 
		// TODO: set up cardboard sdk stuff 
		// TODO: on recticle point, display text from person object

	}

	// Update is called once per frame
	void Update () {
		
	}
}

public class Person {
	public string date;
	public string state;
	public string city;
	public string address;
	public string num_killed;
	public string num_injured;
	public string[] links;
}
