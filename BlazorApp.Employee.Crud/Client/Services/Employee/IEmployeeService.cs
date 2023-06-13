using BlazorApp.Employee.Crud.Shared;

namespace BlazorApp.Employee.Crud.Client.Services.Employee
{
    public interface IEmployeeService
    {
        Task<List<Tb_Employee>?> GetAllAsync();
        Task<Tb_Employee?> Get(int id);
        Task Create(Tb_Employee entity);
        Task Update(int id, Tb_Employee entity);
        Task Delete(int id);
    }
}
