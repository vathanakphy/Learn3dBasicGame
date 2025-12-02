public class WallDetector : MonoBehaviour
{
    public LayerMask wallLayer; // Set this to your Wall layer
    public Color detectedColor = Color.red; // Color to change to
    public float detectionRadius = 1f; // Radius to detect walls

    private void Update()
    {
        // Detect walls in a circle around the player
        Collider[] hitWalls = Physics.OverlapSphere(transform.position, detectionRadius, wallLayer);

        foreach (Collider wall in hitWalls)
        {
            // Change the wall's material color to red
            Renderer wallRenderer = wall.GetComponent<Renderer>();
            if (wallRenderer != null)
            {
                wallRenderer.material.color = detectedColor;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}