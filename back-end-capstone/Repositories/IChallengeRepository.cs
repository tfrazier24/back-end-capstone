using back_end_capstone.Models;

namespace back_end_capstone.Repositories
{
    public interface IChallengeRepository
    {
  
        Challenge GetByLevelId(int id);
    }
}