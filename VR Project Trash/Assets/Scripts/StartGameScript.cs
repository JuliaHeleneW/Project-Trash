using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(delegate { startGame(); });
    }

    public void startGame()
    {
        print("start button clicked");
        SceneManager.LoadScene("SetupTest");
    }

}
