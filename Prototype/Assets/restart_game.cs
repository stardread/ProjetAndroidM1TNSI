using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class restart_game : MonoBehaviour {

    public string sceneToLoad;
	public void RestartGame() {
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        SceneManager.LoadScene(sceneToLoad); // loads current scene

    }

}