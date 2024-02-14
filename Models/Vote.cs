using Google.Cloud.Firestore;

namespace MSHTIN026_Election.Models
{
    [FirestoreData]
    public class Vote
    {
        [FirestoreProperty]
        public int voterID { get; set; }

        [FirestoreProperty]
        public string candidateID { get; set; }

        [FirestoreProperty]
        public string candidateName { get; set; }

        public int VoteCount { get; set; }
    }
}
