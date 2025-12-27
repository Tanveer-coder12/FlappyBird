using UnityEngine;

public class GameMange : MonoBehaviour
{
    public GameObject[] Lifes;
    int CurrentLife;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentLife= Lifes.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
