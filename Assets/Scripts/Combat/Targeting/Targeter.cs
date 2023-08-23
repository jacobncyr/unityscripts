using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Targeter : MonoBehaviour
{
    private List<Target> targets = new List<Target>();
    [SerializeField] private CinemachineTargetGroup cineTargetGroup;
    public Target CurrentTarget { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<Target>(out Target target)) { return; }

        targets.Add(target);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.TryGetComponent<Target>(out Target target)) { return; }

        targets.Remove(target);
    }

    public bool SelectTarget()
    {
        if (targets.Count == 0) { return false; }

        CurrentTarget = targets[0];
        cineTargetGroup.AddMember(CurrentTarget.transform,1f,2f);
        return true;
    }

    public void Cancel()
    {
        if(CurrentTarget == null) { return;}
        cineTargetGroup.RemoveMember(CurrentTarget.transform);
        CurrentTarget = null;

    }
}
