using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.Repositories.BaseRepo;
using Tactsoft.Infrastructure.Persistence;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Application.Repositories.Entities;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(TactsoftDbContext context) : base(context)
    {
    }

}
