﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	List<int> bowls=new List<int>();

	private PinSetter pinSetter;
	private Ball ball;

	// Use this for initialization
	void Start () {
		pinSetter=GameObject.FindObjectOfType<PinSetter>();
		ball=GameObject.FindObjectOfType<Ball>();
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Bowl(int pinFall){
		bowls.Add (pinFall);
		ActionMaster.Action nextAction = ActionMaster.NextAction (bowls);
		pinSetter.PerformAction (nextAction);
		ball.Reset ();
	}
}
