using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Jumpforce, maxUpwardSpeed;
    public GameMange gm;
    public float flapForce;
    public Transform BirdTransform;
    public float Maxheight,minheight;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
   private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flap();
        }
        Vector3 pos = BirdTransform.position;
        pos.y = Mathf.Clamp(pos.y, minheight, Maxheight);
        BirdTransform.position = pos;

    }
  
    void flap()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);
        rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);

        // Clamp upward speed
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, Mathf.Clamp(rb.linearVelocity.y, -maxUpwardSpeed, maxUpwardSpeed));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            gm.lifeloose();

        }
        else if (collision.gameObject.tag=="Pipe")
        {
            gm.lifeloose();
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("Coin");
            gm.Addscore();
        }
    }
}
