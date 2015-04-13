using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
	private GameController gameController;
	
	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Can't find 'GameController' script");
		}
		
	}//Start()
	void OnTriggerExit(Collider other) //Lorsque other sort du volume dans lequel il est (ici le cube de boundary)
	{
		Destroy (other.gameObject); // on le détruit

        ///Custom code=========================================================
		if (other.tag == "Asteroid") 
		{
			gameController.AddMissed();
		}


	}//OnTriggerExit()

}//DestroyByBoundary
