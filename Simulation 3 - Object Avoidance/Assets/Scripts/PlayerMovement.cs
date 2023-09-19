using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Transform target;

    public GameObject Obstic;

    public Vector3 offset;  // The offset of the camera from the player
    public float smoothSpeed = 0.125f; // How smoothly the camera follows

    public float horizontalInput;
    public float verticalInput;

    public float VerticalTwo;
    public Vector3 rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoSomethingCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * 5;
        verticalInput = Input.GetAxis("Vertical") * 5;
        VerticalTwo = Input.GetAxis("Vertical2") * 5;

        if (gameObject.name == ("AUV")) 
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
            }
            if (Input.GetKey(KeyCode.A))
            {

                transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);  
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
            }


            if ( Input.GetKey(KeyCode.UpArrow) )
            {
                Debug.Log(verticalInput);
                transform.Translate(Vector3.up * Time.deltaTime * VerticalTwo);
            }
            //move up
            if ( Input.GetKey(KeyCode.DownArrow) )
            {
                transform.Translate(Vector3.up * Time.deltaTime * VerticalTwo);
            }
            //move down
            if ( Input.GetKey(KeyCode.RightArrow) )
            {
                transform.Rotate(Vector3.up * 100.0f * 1 * Time.deltaTime);
            }
            //rotate right
            if ( Input.GetKey(KeyCode.LeftArrow) )
            {
                transform.Rotate(Vector3.up * 100.0f * -1 * Time.deltaTime);
            }
            //rotate left

    }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.name == ("AUV"))
        {
        Debug.Log(gameObject.name + "Hit a object");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Add your collision handling logic her
        }
    }

    public IEnumerator DoSomethingCoroutine()
    {
        while (true)
        {
            // Code to execute every second.
            Debug.Log("Something happened!");
            float x = Random.Range(-10.0f, 10.0f);
            float y = Random.Range(5.0f,10.0f);
            Vector3 desiredPosition = new Vector3(x, y, target.position.z + 40);
            Instantiate(Obstic, desiredPosition, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
