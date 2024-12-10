using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment19{
public class NewBehaviourScript : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
         transform.position += new Vector3 (0.01f , 0,0);
         transform.position += new Vector3 (0.0 , 0.0 , 0.01f , 0.0);
        // transform.position += new Vector3 (0.01f , 0,0);
        // float xNew = Mathf.Sin(time.time);
        // transform.rotation = Quaternion.Euler (new Vector3 (0, xNew * 45f, 0));
    }
}
}