using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;
	public GUIText missedText;

	private bool gameOver;
	private bool restart;
	private int score;
	private int missed;

	void Start()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		missedText.text = "";
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

			if(gameOver)
			{
				restartText.text = "Press 'R' for restart";
				restart = true;
				break;
			}
		}
	}//SpawnWaves()

	public void AddScore(int newScore)
	{

		score += newScore;
		UpdateScore ();
	}//AddScore()

	public void AddMissed()
	{
		++missed;
		UpdateMissed ();
	}//AddMissed()

	void UpdateMissed()
	{
		if (missed <= 10) 
		{
			missedText.text = "Missed Asteroids " + missed;
		}

	}

	void UpdateScore()
	{
		scoreText.text = "Score : " + score;

	}//UpdateScore

	public void GameOver()
	{
		gameOverText.text = "Game Over, too bad you suck...";
		gameOver = true;
	}


}//GameController
