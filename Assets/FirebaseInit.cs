using UnityEngine;
using Firebase;
using Firebase.Analytics;
public class FirebaseInit : MonoBehaviour
{
    public GameObject Text;
    string stringtext;
    // Start is called before the first frame update
    void Start()
    {
        System.Collections.Generic.Dictionary<string, object> defaults =
     new System.Collections.Generic.Dictionary<string, object>();

        // These are the values that are used if we haven't fetched data from the
        // server
        // yet, or if we ask for values that the server doesn't have:
        defaults.Add("config_test_string", "default local string");
        defaults.Add("config_test_int", 1);
        defaults.Add("config_test_float", 1.0);
        defaults.Add("config_test_bool", false);


       


              FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(/*continuationAction:*/ task =>
       {
           FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);

       });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
