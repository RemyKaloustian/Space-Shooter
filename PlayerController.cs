using UnityEngine;
using System.Collections;
[System.Serializable] //Classe visible dans l'inspecteur
public class Boundary
{
    public float xMin, xMax, zMin, zMax;

}//class Boundary

public class PlayerController : MonoBehaviour
{
    public float m_speed; //A changer dans l'éditeur
    public float tilt;
    public Boundary m_boundary;

    public GameObject shot; //Linké à travers l'éditeur
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    void Update() //appelée à chaque frame
    {//Input.GetButton ("Fire1")
        if (Input.GetKeyDown("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audio.Play();
        }

    }

    void FixedUpdate() // Appelée automatiquement par Unity juste avant chaque thick physique
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Déplacement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbody.velocity = movement * m_speed;//Change la position du vaisseau

        //Empêche de sorttir de la map
        rigidbody.position = new Vector3
            (//Mathf contient des fonctions mathématiques super cools
            //Clamp met la valeur entre un minimum et un maximum
                Mathf.Clamp(rigidbody.position.x, m_boundary.xMin, m_boundary.xMax),
                0.0f,
                Mathf.Clamp(rigidbody.position.z, m_boundary.zMin, m_boundary.zMax)
            );

        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
    }//FixedUpdate()

}//class PlayerController
