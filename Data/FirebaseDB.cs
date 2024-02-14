using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace MSHTIN026_Election.Data
{
    public class FirebaseDB
    {
        FirestoreDb db;
        public FirebaseDB()
        {
            db = FirestoreDb.Create("MSHTIN026 Election");
        }

        public async void AddToDBAsync(string collection, string document, Dictionary<string,object> dict)
        {
            DocumentReference docRef = db.Collection(collection).Document(document);
            Dictionary<string, object> values = dict;
            await docRef.SetAsync(values);
        }

        public async void AddToDBAsync(string collection, string document, Object obj)
        {
            DocumentReference docRef = db.Collection(collection).Document(document);
            await docRef.SetAsync(obj);
        }

        
    }
}
