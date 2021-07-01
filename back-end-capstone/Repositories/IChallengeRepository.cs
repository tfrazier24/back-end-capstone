using back_end_capstone.Models;

namespace back_end_capstone.Repositories
{
    internal interface IChallengeRepository
    {
        void AddChallenge(Challenge challenge);
        void DeleteChallenge(int challengeId);
        void EditChallenge(Challenge challenge);
    }
}