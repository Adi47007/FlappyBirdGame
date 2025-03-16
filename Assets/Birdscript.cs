using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public LogicScript logic;
    public bool birdalive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdalive )
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
        }
        if (transform.position.y>11 || transform.position.y<-11)
        {
            logic.GameOver();
            birdalive = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdalive = false;
    }
}
