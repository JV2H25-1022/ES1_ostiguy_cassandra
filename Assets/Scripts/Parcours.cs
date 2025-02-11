using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parcours : MonoBehaviour
{
    int Time = 5;
    [SerializeReference] private GameObject _plateforme;
    // Start is called before the first frame update
    void Start()
    {
        _plateforme.SetActive(false);
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
