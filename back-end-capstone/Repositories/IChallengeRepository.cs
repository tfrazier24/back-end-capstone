using back_end_capstone.Models;

namespace back_end_capstone.Repositories
{
    internal interface IChallengeRepository
    {
        void AddChallenge(Challenge challenge);
        Challenge GetByLevelId(int id);
    }
}