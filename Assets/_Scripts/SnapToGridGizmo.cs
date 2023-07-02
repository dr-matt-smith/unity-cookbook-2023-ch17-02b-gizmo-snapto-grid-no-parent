using UnityEngine;

[ExecuteInEditMode]
public class SnapToGridGizmo : MonoBehaviour
{
    /**
     * we've moved!
     * snap position to its grid
     */
    public void Update()
    {
#if UNITY_EDITOR
        GridGizmo.GetInstance().SnapPositionToGrid(transform);
#endif
    }
    
}
