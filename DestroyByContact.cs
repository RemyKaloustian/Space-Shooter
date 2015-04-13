using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject explosion; //duh...
	public GameObject playerExplosion; //explosion lors du contact avec le player
	public int scoreValue;
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

	void OnTriggerEnter(Collider other) //Lors d'une collision avec un autre trigger collider
	{
		if (other.tag == "Boundary")//On ne fait rien, pour pas que l'asteroïde soit détruit dès le spawn
		{
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player")
		{
            //On crée l'explosion aux coordonnées de l'objet en contact
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}
		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}//OnTriggerEnter()
}
