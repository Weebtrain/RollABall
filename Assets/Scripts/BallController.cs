using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody ballRigidbody;
    [SerializeField] private float ballSpeed = 1;
    [SerializeField] private float jumpForce = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void MoveBall(Vector3 input)
    {
        input.x *= ballSpeed;
        input.y *= jumpForce;
        input.z *= ballSpeed;
        ballRigidbody.AddForce(input);
    }
}
