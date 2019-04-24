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


    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        count = 0;
        setCountText();
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
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
}
