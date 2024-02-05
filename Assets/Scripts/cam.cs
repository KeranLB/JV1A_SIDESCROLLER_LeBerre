using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    [SerializeField]
    public Transform Subject;

    Vector2 startPosition;

    float startZ;
    float startY;

    Vector2 travel => (Vector2)Subject.transform.position - startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startZ = transform.localPosition.z;
        startY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startPosition + travel;
        transform.position = new Vector3(newPos.x, startY, startZ);
    }
}