using System;
using RootMotion.Dynamics;
using UnityEngine;

public class TestDestroyArea : MonoBehaviour
{
    [SerializeField] private MuscleDisconnectMode _disconnectMuscleMode;
    [SerializeField] private LayerMask _layers;
    [SerializeField] private float _unpin = 10f;
    [SerializeField] private float _force = 10f;

    private Camera _camera;

    private void Awake() => _camera = Camera.main;

    private void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     var ray = _camera.ScreenPointToRay(Input.mousePosition);
        //
        //     // Raycast to find a ragdoll collider
        //     RaycastHit hit = new RaycastHit();
        //     if (Physics.Raycast(ray, out hit, 100f, _layers))
        //     {
        //         var broadcaster = hit.collider.attachedRigidbody.GetComponent<MuscleCollisionBroadcaster>();
        //
        //         // If is a muscle...
        //         if (broadcaster != null)
        //         {
        //             broadcaster.Hit(_unpin, ray.direction * _force, hit.point);
        //
        //             // Remove the muscle and its children
        //             broadcaster.puppetMaster.DisconnectMuscleRecursive(broadcaster.muscleIndex, _disconnectMuscleMode);
        //         }
        //         else
        //         {
        //             // Add force
        //             hit.collider.attachedRigidbody.AddForceAtPosition(ray.direction * _force, hit.point);
        //         }
        //     }
        // }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
    }
}