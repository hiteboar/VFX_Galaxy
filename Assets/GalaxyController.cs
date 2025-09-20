using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[ExecuteAlways]
public class GalaxyController : MonoBehaviour
{
    public VisualEffect[] visualEffects;

    [Range(1, 20)]
    public float impactForce;
    [Range(1, 50)]
    public float impactRadius;

    private bool SetImpactForce = false;

    public void SetImpact(Vector3 impactPosition)
    {
        if (visualEffects == null) return;
        foreach (VisualEffect effect in visualEffects) {
            effect.SetVector3("_ForceCenter", impactPosition);
            effect.SetFloat("_ForceDistance", impactRadius);
        }
        SetImpactForce = true;
    }

    private void FixedUpdate()
    {
        if (visualEffects == null) return;
        foreach (VisualEffect effect in visualEffects) {
            effect.SetFloat("_Force", SetImpactForce ? -impactForce : 0f);
        }
        SetImpactForce = false;
    }

    public void SetForce(float value)
    {
        impactForce = value;
    }

    public void SetDistance(float value)
    {
        impactRadius = value;
    }
}
