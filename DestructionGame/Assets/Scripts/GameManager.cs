using UnityEngine;
using System.Collections;

public class GameManager {

	private static GameManager _instance;

	private static string GAME_SCENE = "GameScene";

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

	//delegates

}
