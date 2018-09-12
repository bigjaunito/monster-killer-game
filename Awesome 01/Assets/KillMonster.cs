using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillMonster : MonoBehaviour {
	int count = 3;
	public SwordHit swordhit;

	// Use this for initialization
	void Start () {

	}
		

	void OnTriggerEnter(Collider other)
		{
		if (other.gameObject.tag == "sword") {
			count -= 1;
			if (count == 0){
				this.gameObject.SetActive (false);
				swordhit.increaseScore ();

			}

		}
			//				count += 1;
//				scoreText.text = "Score: " + count;
//				if (count == 13)
//				{
//					winText.gameObject.SetActive(true);
				} 
	
			}	
	
	// Update is called once per frame
	


	

// Update is called once per frame
//void Update () {

//}


