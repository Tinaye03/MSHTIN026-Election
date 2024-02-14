using System;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using MSHTIN026_Election.Data;
using MSHTIN026_Election.Models;

namespace MSHTIN026_Election.Controllers
{
    public class RegistrationController
    {
        FirebaseDB db;

        public RegistrationController()
        {
            db = new FirebaseDB("voter");

        }

        public void AddVoter(Vote vote)
        {
            try
            {
                db.AddToDB(vote.voterID, vote);
            }
            catch(Exception ex)
            {
                
            }
        }

    }
}
