using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Text countText;
    public float forwardSpeed = 2000f;
    public float sidewayForce = 500f;
    private int count;
    bool isJump = false;
    public float jumpForce = 250f;
    public playerMovement movement;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        count = 0;
        setCountText();
    }

    void Update()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        if (Input.anyKeyDown || Input.anyKey)
        {
 
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(2000 * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey(KeyCode.Space) && !isJump)
            {
                rb.AddForce(Vector3.up * jumpForce);
                isJump = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("icon"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }


    void setCountText()
    {
        countText.text = "golds：" + count.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            movement.enabled = false;
            rb.name = "over";

        }
        if (collision.collider.tag == "plane")
        {
            isJump = false;
        }
    }

}
