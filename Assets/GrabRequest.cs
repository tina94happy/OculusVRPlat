using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabRequest : MonoBehaviour
{
    // Start is called before the first frame update
    private RealtimeTransform realtimeTransform;
    private XRGrabInteractable XRGRabInteractable;
    void Start()
    {
        realtimeTransform = GetComponent<RealtimeTransform>();
        XRGRabInteractable = GetComponent<XRGrabInteractable>();

    }

    // Update is called once per frame
    void Update()
    {
        if (XRGRabInteractable.isSelected)
        {
            realtimeTransform.RequestOwnership();
        }
    }
}
