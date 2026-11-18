using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float forwardForce = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float sidewaysForce = 10.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, forwardForce);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
    }
}
