using UnityEngine;
using TMPro;
public class GameMange : MonoBehaviour
{
    public GameObject[] Lifes;
    int CurrentLife;
    public TMP_Text txt;
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
