using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPR11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Fade");
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    IEnumerator Fade() 
{
            Debug.Log("Ik start nu de coroutine");
            yield return new WaitForSeconds(.5f);
            Debug.Log("Coroutine update");
            yield return new WaitForSeconds(.5f);
            Debug.Log("Coroutine einde");
            yield return new WaitForSeconds(.5f);
}

}
