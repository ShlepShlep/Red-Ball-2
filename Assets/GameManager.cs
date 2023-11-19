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
        }
        else
        {
            Destroy(this);
            print("Found another singleton instance !!!! Die !!!!");
        }
    }

    public void Win()
    {
        currentLevel++;
        SceneManager.LoadScene(levels[currentLevel]);
    }

    public void Lose()
    {

    }
}