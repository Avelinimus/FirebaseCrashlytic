using UnityEngine;
using UnityEngine.Diagnostics;

public class Crashlytic : MonoBehaviour
{
    public int updatesBeforeException;

    void Start()
    {
        Firebase.FirebaseApp app = Firebase.FirebaseApp.DefaultInstance;
        UnityEngine.Diagnostics.Utils.ForceCrash(ForcedCrashCategory.AccessViolation);
    }
}
