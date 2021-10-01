using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uigyu : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D tidodik;

    [SerializeField]
    private KeyCode left = KeyCode.A;

    [SerializeField]
    private KeyCode right = KeyCode.D;

    [SerializeField]
    private KeyCode up = KeyCode.W;

    [SerializeField]
    private int Force = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(left))
        {
            tidodik.AddForce(Vector2.left * Force);
        }
        if (Input.GetKey(right))
        {
            tidodik.AddForce(Vector2.right * Force);
        }
        if (Input.GetKey(up))
        {
            tidodik.AddForce(Vector2.up * Force);
        }
    }
}
