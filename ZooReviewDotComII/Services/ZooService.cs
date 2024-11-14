using Microsoft.EntityFrameworkCore;
using ZooReviewDotComII.Data;
using ZooReviewDotComII.Models;
namespace ZooReviewDotComII.Services;

public class ZooService
{
    private readonly ApplicationDbContext _context;

    public ZooService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Zoo>> GetZoosAsync()
    {
        return await _context.Zoos.ToListAsync();
    }
}