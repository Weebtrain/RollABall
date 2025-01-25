using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
    private float jumpAdd = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            jumpAdd = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero; // intialize our input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            inputVector += Vector3.up * jumpAdd;
            jumpAdd = 0;
        }
        OnMove?.Invoke(inputVector);
    }
}
