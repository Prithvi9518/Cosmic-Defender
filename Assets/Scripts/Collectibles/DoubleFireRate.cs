using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleFireRate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShootingController controller = collision.GetComponent<ShootingController>();

        if(controller != null)
        {
            if(controller.fireRate<=0.05f)
            {
                Destroy(gameObject);
                controller.fireRate /= 2;
            }
        }
    }

}
