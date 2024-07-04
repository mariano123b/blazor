using BlazorAppVSCode.Models;
using System.Text.Json;

namespace BlazorAppVSCode.Services
{
    public class AlumnoService : IAlumnoServices
    {
        private readonly HttpClient client;
        //private readonly JsonSerializerOptions options;

        public AlumnoService(HttpClient client, JsonSerializerOptions options)
        {
            this.client = client;
           // this.options = options;
        }
        public async Task<List<Alumno>?> Get()
            {
                var response = await client.GetAsync("apialumnos");
                return await JsonSerializer.DeserializeAsync<List<Alumno>>(await response.Content.ReadAsStreamAsync());

            }
    }
    public interface IAlumnoServices
    {
        public Task<List<Alumno>?> Get();
    }
}
