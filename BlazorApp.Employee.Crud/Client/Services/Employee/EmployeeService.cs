using BlazorApp.Employee.Crud.Shared;
using System.Net.Http.Json;

namespace BlazorApp.Employee.Crud.Client.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            this._http = http;
        }

        public async Task Create(Tb_Employee entity)
        {
            await _http.PostAsJsonAsync("api/employee/create",entity);
        }

        public async Task Delete(int id)
        {
            await _http.DeleteAsync("api/employee/delete?id="+id);
        }

        public async Task<Tb_Employee?> Get(int id)
        {
            return await _http.GetFromJsonAsync<Tb_Employee>("api/employee/" + id);
        }

        public async Task<List<Tb_Employee>?> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Tb_Employee>>("api/employee");

        }

        public async Task Update(int id, Tb_Employee entity)
        {
            await _http.PutAsJsonAsync("api/employee/update/" + id, entity);
        }
    }
}
