using UnityEngine;

public class cube_testing : MonoBehaviour
{

    Rigidbody rb;

    public int hitCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello: " + gameObject.name);
        //Destroy(gameObject, 3f);

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);
            //rb.AddForce(Vector3.up * 200);
        }

        //rb.velocity = Vector3.forward * 2f;

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            hitCount++;

            if ((hitCount % 2) == 0)
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
            }

            Debug.Log("hitCount: " + hitCount);
        }
    }

}
