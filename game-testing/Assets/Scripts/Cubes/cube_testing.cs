using UnityEngine;
using UnityEngine.SceneManagement;

public class cube_testing : MonoBehaviour
{

    Rigidbody rb;

    public GameObject winText;

    float xInput;
    float zInput;
    public float speed;

    private int hitCount = 0;
    //public int lengthi = 10;
    //public int lengthj = 10;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello: " + gameObject.name);
        //Destroy(gameObject, 3f);

        rb = GetComponent<Rigidbody>();

        //for (int i = 0; i <= lengthi; i++)
        //{
        //    for (int j = 0; j <= lengthj; j++)
        //    {
        //        Debug.Log(i + ", " + j);
        //    }
        //}

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level2");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("MyScene");
        }

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, zInput * speed);

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

            //Debug.Log("hitCount: " + hitCount);
            //Destroy(gameObject);
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
            //winText.SetActive(true);

        }
    }

}
