using API.DTOs;
using API.Entities;
using API.Interfaces;

namespace API.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataContext _context;
        public LikesRepository(DataContext context)
        {
            _context = context;
            
        }
        public async Task<UserLike> GetUserLike(int SourceUserId, int TargetUserId)
        {
            return await _context.Likes.FindAsync(SourceUserId, TargetUserId);
        }

        public async Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithLikes(int userId)
        {
            throw new NotImplementedException();
        }
    }
}