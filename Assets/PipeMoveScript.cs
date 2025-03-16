using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movespeed = 5;
    public float deadzone = -40;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
        transform.position += Vector3.left * movespeed * Time.deltaTime;
    }
}
