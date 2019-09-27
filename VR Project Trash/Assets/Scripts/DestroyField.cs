using UnityEngine;
using System.Collections;

public class DestroyField : MonoBehaviour
{
    public string trashName1;
    public string trashName2;
    public string trashName3;
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == trashName1)
        {
            Destroy(other.gameObject);
        }
        else if(other.tag == trashName2){
            Destroy(other.gameObject);
        }
        else if (other.tag == trashName3){
            Destroy(other.gameObject);
        }
    }
    
}
