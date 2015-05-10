using UnityEngine;
using System.Collections;

public class ColorSetter : MonoBehaviour 
{

    public Light _colorLight;

	// Use this for initialization
	void Start () 
    {
        switch(PlayerPrefs.GetString("_color"))
        {
            case "blue": _colorLight.color = Color.blue; break;
            case "green":_colorLight.color= Color.green; break;
            case "red": _colorLight.color = Color.red; break;
            case "cyan": _colorLight.color = Color.cyan; break;
            case "yellow": _colorLight.color = Color.yellow; break;
            case "magenta": _colorLight.color = Color.magenta; break;
            case "white": _colorLight.color = Color.white; break;

        }
               
	}//Start()
	
	// Update is called once per frame
	void Update ()
    {
	
	}//Update()
}//class ColorSetter
