using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEcon : MonoBehaviour {

	public float playerStartingMoney;
	private float currentPlayerMoney;

	// Use this for initialization
	void Start () {
		currentPlayerMoney = playerStartingMoney;
	}

	public void addMoney(float amount){
		currentPlayerMoney += amount;
	}

	public void removeMoney(float amount){
		currentPlayerMoney -= amount;
	}

	public float getCurrentMoney(){
		return currentPlayerMoney;
	}

}
