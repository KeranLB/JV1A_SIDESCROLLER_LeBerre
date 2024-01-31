using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftkey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow, upKey = KeyCode.UpArrow, downKey = KeyCode.DownArrow;

    [SerializeField]
    private Rigidbody2D rgbd;

    [SerializeField]
    private Rigidbody2D leftside;

    [SerializeField]
    private Rigidbody2D rightside;

    public bool IsTouchingLayers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftkey))
        {
            rgbd.AddForce(Vector2.left * 1);
        }

        if (Input.GetKey(rightKey))
        {
            rgbd.AddForce(Vector2.right * 1);
        }

        if (Input.GetKey(downKey))
        {
            rgbd.AddForce(Vector2.down * 10);
        }

        if (IsTouchingLayers) ;
        {
            if (Input.GetKeyDown(upKey))
            {
                rgbd.AddForce(Vector2.up * 600);
            }
        }
    }
}
