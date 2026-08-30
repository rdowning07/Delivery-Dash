using UnityEngine;
using UnityEngine.InputSystem;
public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float steer = 0f;
        float move = 0f;

        if(Keyboard.current.wKey.isPressed)
        {
            move =1f;
        }
        else if(Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        if(Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        if(Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }
        transform.Rotate(0, 0, steerSpeed * steer);
        transform.Translate(0, moveSpeed * move, 0);
    }
}