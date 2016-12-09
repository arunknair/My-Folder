using UnityEngine;
using System.Collections;

public class CarLight : MonoBehaviour {
//git testing command
	public Renderer brakelights;
	public Material brakelightON;
	public Material brakelightsOFF;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.DownArrow))
			brakelights.material = brakelightON;
		else
			brakelights.material = brakelightsOFF;
	}
}
