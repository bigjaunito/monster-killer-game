﻿using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class NavmeshAgentScript : MonoBehaviour {


	public Transform player;
	NavMeshAgent agent;

	void Start ()
	{

		agent = GetComponent<NavMeshAgent> ();


	}

	void Update ()
	{		agent.SetDestination(player.position);
	}
}
