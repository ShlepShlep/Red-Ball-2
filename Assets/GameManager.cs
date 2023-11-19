using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// singleton

public class GameManager : MonoBehaviour
{
    public int hp;
    public int currentLevel;

    public List<string> levels;
    public static GameManager instance;


    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }else {
            Destroy(this);
            print("Found another singleton instance !!!! Die !!!!");
        }
    }

    public void Win()
    {
        currentLevel++;
        Invoke("LoadScene",1f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(levels[currentLevel]);
    }

    public void Lose()
    {
        hp--;
        if (hp > 0)
        {
            // restart
            Invoke("LoadScene",1f);
        }
        else
        {
            // restart to level 0
            currentLevel = 0;
            Invoke("LoadScene",1f);
        }

    }
}