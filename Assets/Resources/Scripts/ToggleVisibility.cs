using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    // Inspector'da atanacak alanlar
    public GameObject objectToClose; // Kapatılacak GameObject
    public GameObject objectToOpen;  // Açılacak GameObject

    // Bu fonksiyon, buton tarafından çağrılır
    public void Toggle()
    {
        // Eğer kapatılacak obje atanmışsa, kapat
        if (objectToClose != null)
        {
            objectToClose.SetActive(false);
        }

        // Eğer açılacak obje atanmışsa, aç
        if (objectToOpen != null)
        {
            objectToOpen.SetActive(true);
        }
    }
}
