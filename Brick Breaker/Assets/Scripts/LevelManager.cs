using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
        Block.breakableCount = 0;
        Debug.Log ("New Level load: " + name);
        SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void LoadNextLevel()
    {
        Block.breakableCount = 0;
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public void BrickDestroyed()
    {
        if (Block.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }

}
