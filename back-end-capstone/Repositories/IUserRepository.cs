using back_end_capstone.Models;

namespace back_end_capstone.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetByFirebaseUserId(string firebaseUserId);
    }
}