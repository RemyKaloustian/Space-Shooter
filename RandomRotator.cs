using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour 
{

	public float tumble; //Dans l'éditeur

	void Start()
	{
        //angularVelocity = vitesse de rotation d'un objet
        //isideUnitSphere = random valeur de vecteur 3
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}//RandomRotator
