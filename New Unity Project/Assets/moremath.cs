using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moremath : MonoBehaviour {
	public int speed1 = 70;
	public int speed2 = 60;
	public int hours = 1;
	public string distance;
	// Use this for initialization
	void Start () {
		distance = speed1 + speed2;

		print ("A train leaves City A and drives west at 70 mph. Another train leaving City A driving" +
		"east is traveling at 60 mph. How many miles are the trains apart after 1 hour?");
	
		print ("the trains will be" + distance + "miles apart after 1 hour");
	}
	

	}

