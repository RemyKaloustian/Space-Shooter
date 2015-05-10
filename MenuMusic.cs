using UnityEngine;
using System.Collections;

public class MenuMusic : MonoBehaviour {

    public AudioSource _menuTheme;

	// Use this for initialization
	void Start () {
        _menuTheme.Play();
        Debug.Log("Isplaying");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
