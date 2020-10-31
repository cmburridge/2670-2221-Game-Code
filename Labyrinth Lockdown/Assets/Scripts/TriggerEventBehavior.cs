using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;
    public float delayTime = 1f;
    private WaitForSeconds waitObj;

    private void Start()
    {
        waitObj = new WaitForSeconds(delayTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return waitObj;
        triggerEnterEvent.Invoke();
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        yield return waitObj;
        triggerExitEvent.Invoke();
    }
}
