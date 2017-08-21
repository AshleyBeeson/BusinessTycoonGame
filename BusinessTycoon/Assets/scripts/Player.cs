using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string playerName;
	private BasicEcon econ;

	// Use this for initialization
	void Start () {
		econ = this.GetComponent<BasicEcon>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		GUI.Label(new Rect(10,10,100,50), playerName + "  $$$: " + econ.getCurrentMoney());
	}



}
