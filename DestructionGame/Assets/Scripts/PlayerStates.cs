using UnityEngine;
using System.Collections;

public class PlayerStates : MonoBehaviour {

	private enum PlayerState {
		IDLE, WALKING, ATTACKING, ENDING }

	PlayerState state = PlayerState.IDLE;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Update () {
		switch (state) {
		case PlayerState.IDLE:
			break;

		case PlayerState.WALKING:
			break;

		case PlayerState.ATTACKING:
			break;

		//after timer is out - losing/winning ending
		case PlayerState.ENDING:
			break;
		}
	
	}
}
