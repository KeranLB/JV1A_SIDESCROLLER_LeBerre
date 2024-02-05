using UnityEngine;

public class Ennemies : MonoBehaviour
{
    private string pointObjectiv;
    
    public float moovSpeed;
    public Rigidbody2D rgbd;
    public Transform pointA;
    public Transform pointB;

    // Start is called before the first frame update
    void Start()
    {
        pointObjectiv = "B";
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>().GotShield == false)
        {
            Destroy(col.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

// Update is called once per frame
void Update()
    {
        if (pointB.position.x == gameObject.transform.position.x)
        {
            pointObjectiv = "A";
        }
        if (pointA.position.x == gameObject.transform.position.x)
        {
            pointObjectiv = "B";
        }

        if (pointObjectiv == "B")
        {
            rgbd.AddForce(Vector2.right * moovSpeed);
        }
        else if (pointObjectiv == "A");
        {
            rgbd.AddForce(Vector2.left * moovSpeed);
        }
    }
}
