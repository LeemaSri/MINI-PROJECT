using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SkullMandibleInteractable : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool isGrabbed = false;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    public void Grab()
    {
        // Logic for when the piece is grabbed
        isGrabbed = true;
    }

    public void Release()
    {
        // Logic for when the piece is released
        isGrabbed = false;
    }

    public void SnapToPosition(Vector3 snapPosition, Quaternion snapRotation)
    {
        // Snap the piece to the provided position and rotation
        transform.position = snapPosition;
        transform.rotation = snapRotation;
    }

    public bool IsGrabbed()
    {
        return isGrabbed;
    }

    public void ResetPosition()
    {
        // Reset the piece to its original position and rotation
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }
}
