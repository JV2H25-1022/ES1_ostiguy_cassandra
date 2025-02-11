using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Detruire")){
            Destroy(collision.gameObject);
            
        }
        
    
    
}
}
