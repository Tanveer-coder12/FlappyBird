using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Renderer rn;
    public float BgSpeed;
    private void Awake()
    {
        rn = gameObject.GetComponent<Renderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offset = BgSpeed * Time.deltaTime;
       rn.material.mainTextureOffset += new Vector2(offset,0);
    }
}
