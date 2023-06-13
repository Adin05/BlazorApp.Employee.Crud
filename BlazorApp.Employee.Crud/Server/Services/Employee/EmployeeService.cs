using BlazorApp.Employee.Crud.Server.Data;
using BlazorApp.Employee.Crud.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Employee.Crud.Server.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            this._context = context;
        }
        public async Task Create(Tb_Employee entity)
        {
            await _context.Employees.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);
            if (entity != null)
            {
                _context.Employees.Remove(entity);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Tb_Employee?> Get(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<Tb_Employee>?> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task Update(int id, Tb_Employee entity)
        {
            var model = await _context.Employees.FindAsync(id);
            if (model != null)
            {
                model.Name = entity.Name;
                model.Status = entity.Status;
                model.Email= entity.Email;
                model.Address = entity.Address;
                model.NIK = entity.NIK;
            }
            await _context.SaveChangesAsync();
        }
    }
}
