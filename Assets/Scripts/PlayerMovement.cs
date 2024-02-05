using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // public variable
    public KeyCode leftKey, rightKey, upKey;
    
    public Rigidbody2D rgbd;

    public Transform LeftCheckGrounbed;
    public Transform RightCheckGrounded;

    public Transform TopLeftCheckWalled;
    public Transform BottomLeftCheckWalled;

    public Transform TopRightCheckWalled;
    public Transform BottomRightCheckWalled;
    
    public float jumpForce;
    public float moovSpeed;

    public bool GotShield;

    // private variables
    private bool IsGrounded;
    private bool IsLeftWalled;
    private bool IsRightWalled;



    void Start()
    {
        GotShield = false;

    }

    void Update()
    {
        IsGrounded = Physics2D.OverlapArea(LeftCheckGrounbed.position, RightCheckGrounded.position);
        IsLeftWalled = Physics2D.OverlapArea(TopLeftCheckWalled.position, BottomLeftCheckWalled.position);
        IsRightWalled = Physics2D.OverlapArea(TopRightCheckWalled.position, BottomRightCheckWalled.position);

        if (Input.GetKey(leftKey))
        {
            rgbd.AddForce(Vector2.left * moovSpeed);
        }
        if (Input.GetKey(rightKey))
        {
            rgbd.AddForce(Vector2.right * moovSpeed);
        }
        if (IsGrounded)
        {
            if (Input.GetKeyDown(upKey))
            {
                rgbd.AddForce(Vector2.up * jumpForce);
            }
        }
        else if (IsLeftWalled)
        {
            if (Input.GetKeyDown(upKey))
            {
                rgbd.AddForce(Vector2.up * jumpForce * 0.75f);
                rgbd.AddForce(Vector2.right * jumpForce);
            }       
        }
        else if (IsRightWalled)
        {
            if(Input.GetKeyDown(upKey))
            {
                rgbd.AddForce(Vector2.up * jumpForce * 0.75f);
                rgbd.AddForce(Vector2.left * jumpForce);
            }
        }
    }
}
