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
	void OnTriggerExit(Collider other)
	{
		Destroy (other.gameObject);
		if (other.tag == "Asteroid") 
		{
			gameController.AddMissed();
		}


	}//OnTriggerExit()

}//DestroyByBoundary
