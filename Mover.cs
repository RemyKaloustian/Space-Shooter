using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{

	public float speed;//Dans l'éditeur
	// Use this for initialization
	void Start () 
	{
		rigidbody.velocity = transform.forward * speed; //Va tout droit grâce au transfrom.forward
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}//Mover
