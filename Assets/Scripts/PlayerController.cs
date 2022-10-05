using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Unit unit = GetComponent<Unit>();
        speed = unit.Speed;

        Debug.Log("speed: " + speed);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sensor"))
        {
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
        }
    }

}
