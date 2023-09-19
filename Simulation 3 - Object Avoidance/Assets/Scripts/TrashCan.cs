using UnityEngine;

public class TrashCan : MonoBehaviour
{
    public GameObject referenceObject;
    public GameObject objectToDestroy;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        if (objectToDestroy == null || referenceObject == null)
        {
            Debug.LogWarning("Reference object or object to destroy is not assigned.");
            return;
        }

        // Get the Z position of the objectToDestroy in referenceObject's local space
        float zPositionRelativeToReference = referenceObject.transform.InverseTransformPoint(objectToDestroy.transform.position).z;

        // Check if the objectToDestroy is behind the referenceObject
        if (zPositionRelativeToReference < -20f)
        {
            if (gameObject.name == "Obsic Cube(Clone)")
            {
                Destroy(objectToDestroy);
            }
        }
        
    }
}