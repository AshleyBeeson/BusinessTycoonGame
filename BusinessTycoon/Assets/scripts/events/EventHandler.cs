using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{

    private Random random = new Random();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



	public bool hasEventTriggered(float chance){
		float rnd = Random.Range(0,100);
		return rnd >= chance;
	}

}
