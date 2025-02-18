using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAControl : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody2D rb2d;
    public float t = 0.01f;

    // Start is called before the first frame update
    void Start()
    {   
        rb2d = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        var ball_pos = ball.transform.position;
        Vector3 p0 = transform.position;
        Vector3 p1 = new Vector3((transform.position.x + ball_pos.x) / 2, transform.position.y, transform.position.z);
        Vector3 p2 = new Vector3(ball_pos.x, transform.position.y, transform.position.z);

        Vector3 new_pos = Mathf.Pow(1 - t, 2) * p0 + 2 * (1 - t) * t * p1 + Mathf.Pow(t, 2) * p2;
        transform.position = new Vector3(new_pos.x, transform.position.y, transform.position.z);
    }
}
