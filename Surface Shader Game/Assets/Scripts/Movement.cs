using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    float moveX;
    float moveY;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        if (moveY != 0)
        {
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }
        transform.position += transform.forward * speed * moveY / 50;
        transform.Rotate(Vector3.up * moveX * turnSpeed);
    }
}