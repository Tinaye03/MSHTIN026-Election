using Google.Cloud.Firestore;

namespace MSHTIN026_Election.Models
{
    [FirestoreData]
    public class RegisteredVoter
    {
        [FirestoreProperty]
        public string ID { get; set; }

        [FirestoreProperty]
        public string FirstName { get; set; }

        [FirestoreProperty]
        public string LastName { get; set; }

        [FirestoreProperty]
        public DateTime? DateOfBirth { get; set; }

    }
}
