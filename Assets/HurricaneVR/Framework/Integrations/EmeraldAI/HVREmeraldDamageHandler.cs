using System.Collections;
using System.Collections.Generic;
using EmeraldAI;
using HurricaneVR.Framework.Components;
using UnityEngine;

public class HVREmeraldDamageHandler : HVRDamageHandlerBase
{

    public EmeraldAISystem EmeraldAISystem;
    public bool SearchParentForAI = true;

    public void Start()
    {
        if (!EmeraldAISystem)
        {
            EmeraldAISystem = GetComponent<EmeraldAISystem>();
        }

        if (!EmeraldAISystem && SearchParentForAI)
        {
            EmeraldAISystem = GetComponentInParent<EmeraldAISystem>();
        }
    }

    public override void HandleDamageProvider(HVRDamageProvider damageProvider, Vector3 hitPoint, Vector3 direction)
    {
        if (EmeraldAISystem)
        {
            EmeraldAISystem.Damage((int)damageProvider.Damage, EmeraldAISystem.TargetType.Player, damageProvider.Player ? damageProvider.Player : damageProvider.transform);
        }
    }

}
