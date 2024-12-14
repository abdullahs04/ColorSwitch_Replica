using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(2 * direction * Time.deltaTime, 0, 0);

        
          
        if (transform.position.x >4 || transform.position.x<-4)
        {
            direction *= -1;
        }
        
    }
}
