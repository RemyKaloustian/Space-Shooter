using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public GameObject hazard;
	public Vector3 spawnValues;
	private int hazardCount;
    private int hazardAdded;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	
	
	public Text missedText;
    public GameObject _gameOverPanel;
    public Text _scoreText;
    public Text _recordText;

	private bool gameOver;
	private bool restart;
	private int score;
	private int missed;

	void Start()
	{
		gameOver = false;
		restart = false;
        hazardCount = 5;
        hazardAdded = 5;
		score = 0;
		missed = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}//Start()

	void Update()
	{
		if (restart) 
		{
			if(Input.GetKeyDown(KeyCode.R))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while (true) 
		{
			for (int i = 0; i< hazardCount; ++i) 
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
               
			}
			yield return new WaitForSeconds (waveWait);
            hazardCount += hazardAdded;
            Debug.Log("Vague de  :  " + hazardCount);
			if(gameOver)
			{
				
				restart = true;
				break;
			}
		}
	}//SpawnWaves()

	public void AddScore()
	{
		score ++;
		UpdateScore ();
	}//AddScore()

	public void AddMissed()
	{
		++missed;
		UpdateMissed ();
	}//AddMissed()

	void UpdateMissed()
	{
        Debug.Log("Missed : " + missed);
		if (missed <=10) 
		{
			missedText.text  = "Astéroïdes manqués : " + missed;
		}

        if(missed == 10)
        {
            GameOver();
        }

	}//UpdateMissed()

	void UpdateScore()
	{
		

	}//UpdateScore

	public void GameOver()
	{
		//gameOverText.text = "Game Over, too bad you suck...";
		gameOver = true;
        _scoreText.text += score.ToString();

        if (PlayerPrefs.GetInt("_record") < score)
            PlayerPrefs.SetInt("_record", score);

        _recordText.text += PlayerPrefs.GetInt("_record").ToString();


        _gameOverPanel.SetActive(true);

	}//GameOver()


}//GameController
