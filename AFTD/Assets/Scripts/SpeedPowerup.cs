﻿using UnityEngine;
using System.Collections;

public class SpeedPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerEnter2D(Collider2D collis)
	{
		if (collis.gameObject.tag == "Player") 
		{
			PlayerController playerController = collis.GetComponent<PlayerController>();
			playerController.ProcessPowerUp("speedPowerUp");
			Destroy (this.gameObject);
		} 
	}
}
