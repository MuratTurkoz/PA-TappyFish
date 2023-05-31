using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float distance=10.36f;
    BoxCollider2D box;
    float groundWidht;
    // Start is called before the first frame update
    void Start()
    {
        box= GetComponent<BoxCollider2D>();
        groundWidht = box.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speedX * Time.deltaTime, transform.position.y);
        if (transform.position.x <= -groundWidht)
        {
            transform.position = new Vector2(transform.position.x+2*groundWidht, transform.position.y);
        }
    }

}
