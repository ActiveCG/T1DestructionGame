using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager {

	private static GameManager _instance;

	private static string[] GAME_SCENES = {"GameScene","GameScene2"};

	private GameObject _player;

	//getters:
	public static GameManager instance{
		get {
			if (_instance == null)
				_instance = new GameManager ();
			return _instance;
		}
	}

	public GameObject player{
		get {
			if (_player == null)
				_player = GameObject.FindGameObjectWithTag("Player");
			return _player;
		}
	}

	//scene management
	public void StartNewLevel(){
		SceneManager.LoadScene (GAME_SCENES[0]); //UPDATE FOR MORE LEVELS
		Time.timeScale = 1;
	}

	//delegates

}
