using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttoon : MonoBehaviour
{

    public static string CurrL;
    // Start is called before the first frame update
    void Start()
    {
        CurrL=SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goBackToMainScene()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Restart()
    {
        player.life = 3;
        SceneManager.LoadScene(CurrL);
    }

    public void goToLevel1()
    {
        player.life = 3;
        SceneManager.LoadScene("Level1");
    }

    public void goToLevel2()
    {
        player.life = 3;
        SceneManager.LoadScene("Level2");
    }
    public void goToLevel3()
    {
        player.life = 3;
        SceneManager.LoadScene("Level3");
    }
    public void goToLevel4()
    {
        player.life = 3;
        SceneManager.LoadScene("Level4");
    }
    public void goToLevel5()
    {
        player.life = 3;
        SceneManager.LoadScene("Level5");
    }

    public void goToLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
