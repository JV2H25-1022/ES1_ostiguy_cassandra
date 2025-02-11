using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parcours : MonoBehaviour
{
    int Time = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Terminus")){
            Invoke("Redemarrer", Time);
        }
    }

    void Redemarrer(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

}
}
