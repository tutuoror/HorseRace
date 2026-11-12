using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbPlayer.AddForce(-5.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbPlayer.AddForce(5.0f, 0.0f, 0.0f);
        }
    }
}
