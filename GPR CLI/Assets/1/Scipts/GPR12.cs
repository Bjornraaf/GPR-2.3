using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPR12 : MonoBehaviour
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

        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Debug.Log("Coroutine update");
            yield return new WaitForSeconds(.5f);
        }

        Debug.Log("Coroutine einde");
        yield return new WaitForSeconds(.5f);
    }
}
