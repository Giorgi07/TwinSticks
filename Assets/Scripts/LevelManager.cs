using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadScene (string name) {
		EditorSceneManager.LoadScene (name);
	}

	public void QuitGame() {
		Application.Quit ();
	}

}
