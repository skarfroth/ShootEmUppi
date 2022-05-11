using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float timeUntilDestroy = 2f;
    void Update()
    {
        Destroy(this.gameObject, timeUntilDestroy);
    }
}
