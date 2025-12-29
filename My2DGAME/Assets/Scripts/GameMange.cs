using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameMange : MonoBehaviour
{
    public GameObject[] Lifes;
    int CurrentLife;
    public Text txt; 
    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentLife= Lifes.Length;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scoreSystem()
    {
        
        txt.text = score.ToString();
    }
    public void Addscore()
    {
        score += 1;
        scoreSystem();
    }
    public void lifeloose()
    {
        if (CurrentLife <= 0)
        
            return;
            CurrentLife--;

        Destroy(Lifes[CurrentLife]);
        if(CurrentLife<= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
}
