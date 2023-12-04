using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SlowEffect : MonoBehaviour
{
    public PostProcessVolume postProcess;
    

    // Start is called before the first frame update
    void Start()
    {
        postProcess.profile.TryGetSettings(out Vignette vignette);
        vignette.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (postProcess.profile.TryGetSettings(out Vignette vignette))
        {
            if (Time.deltaTime != 1f)
            {
                vignette.active = true;
            }
            else
            {
                vignette.active = false;
            }
        }



    }
}
