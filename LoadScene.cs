using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour 
{
   // public GameObject _mainPanel;
  //  public GameObject _tutoPanel;

	// Use this for initialization
	void Start () 
    {
	
	}//Start()
	
	// Update is called once per frame
	void Update ()
    {
	
	}//Update()

    public void LoadTuto()
    {
       
       // _mainPanel.SetActive(false);
       // _tutoPanel.SetActive(true);
        Application.LoadLevel("Tuto");
    }//LoadTuto()

    public void LoadMain()
    {
        Application.LoadLevel("Main");
    }//LoadMain()

    public void LoadCustomizeShip()
    {
        Application.LoadLevel("CustomizeShip");
    }//LoadCustomizeShip()

    public void BlankShip()
    {
        PlayerPrefs.SetString("_color", "white");
        LoadTuto();
    }//BlankShip()

    public void GreenShip()
    {
        PlayerPrefs.SetString("_color", "green");
        LoadTuto();
    }//GreenShip()

    public void RedShip()
    {
        PlayerPrefs.SetString("_color", "red");
        LoadTuto();
    }//RedShip

    public void YellowShip()
    {
        PlayerPrefs.SetString("_color", "yellow");
        LoadTuto();
    }//YellowShip()

    public void  TurquoiseShip()
    {
        PlayerPrefs.SetString("_color", "cyan");
        LoadTuto();
    }//TurquoiseShip()

    public void  VioletShip()
    {
        PlayerPrefs.SetString("_color", "magenta");
        LoadTuto();
    }//VioletShip()

    public void BlueShip()
    {
        PlayerPrefs.SetString("_color", "blue");
        LoadTuto();
    }//BlueShip()

   

    
}// class LoadScene
