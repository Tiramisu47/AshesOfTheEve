using UnityEngine;

public static class GlobalHelper
{
    public static string GenerateUniqueID(GameObject obj)
    {
        return $"{obj.scene.name} {obj.transform.position.x} {obj.transform.position.y}";
        ;
    }
}
