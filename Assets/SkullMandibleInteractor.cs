using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SkullMandibleInteractor : MonoBehaviour
{
    public XRSocketInteractor socketInteractor; // Reference to the socket interactor

    private void Start()
    {
        // Get reference to the XRSocketInteractor component dynamically
        socketInteractor = GetComponent<XRSocketInteractor>();

        // Subscribe to the Select Exited event
        if (socketInteractor != null)
        {
            socketInteractor.selectExited.AddListener(OnSelectExited);
        }
        else
        {
            Debug.LogWarning("XRSocketInteractor component is missing on the GameObject with SkullMandibleInteractor script.");
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        // Get the interactable object that exited the socket
        IXRSelectInteractable interactableObject = args.interactableObject;

        // Check if the interactable is a skull piece
        if (interactableObject != null)
        {
            // Cast the interactableObject to XRBaseInteractable
            XRBaseInteractable interactable = interactableObject as XRBaseInteractable;

            // Call the Release method of the skull piece interactable
            if (interactable != null)
            {
                interactable.GetComponent<SkullMandibleInteractable>().Release();
            }
        }
    }
}
