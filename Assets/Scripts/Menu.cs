using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    


	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(GameManager.Instance.state);
	}


    public void StartLevel()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
        GameManager.Instance.state = game.game;
        //Change game manager state here
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        GameManager.Instance.state = game.mainmenu;
        //Change game manager state here
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        GameManager.Instance.state = game.credits;
        //Change game manager state here
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<PlayerController>().Transition(gamestate.init);
        
        GameManager.Instance.state = game.game;
        //Change game manager state here
    }

}
