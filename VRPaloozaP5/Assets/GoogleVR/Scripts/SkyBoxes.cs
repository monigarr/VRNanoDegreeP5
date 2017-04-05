using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxes : MonoBehaviour {

	public Material DSB;
	public Material DSBWP;
	public Material DSG;
	public Material DSGWP;
	public Material DSR;
	public Material DSRWP;

	// Use this for initialization
	void Start () {

		RenderSettings.skybox = DSB;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}