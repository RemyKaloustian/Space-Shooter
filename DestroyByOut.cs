using UnityEngine;
using System.Collections;

public class DestroyByOut : MonoBehaviour 
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
		Debug.Log ("Dans OnTriggerExit");
		gameController.AddMissed ();
		Destroy (other.gameObject);

	}//OnTriggerExit()
	
}//DestroyByOut
