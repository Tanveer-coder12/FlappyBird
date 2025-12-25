using Unity.VisualScripting;
using UnityEngine;

public class PipeSystem: MonoBehaviour
{
    public GameObject pipes;
    public Transform spawnpos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawnpiep", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (pipes.transform.position.x < -6f)
        {
            Destroy(pipes);
        }
    }
    void Spawnpiep()
    {
        float rn = Random.Range(-2.5f, 2.5f);
        Vector2 spawnposition = new Vector2(spawnpos.position.x,rn);
       GameObject pipline = Instantiate(pipes,spawnposition,Quaternion.identity);
       Destroy(pipline,10f);
    }
}
