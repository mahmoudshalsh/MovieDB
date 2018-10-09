using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ttt.Models
{
    public class GenreRepo
    {
        public async Task<GenresList> GetAll()
        {
            var response = await new HttpClient().GetAsync("https://api.themoviedb.org/3/genre/movie/list?api_key=26cf162ffbd66eae91c236838e871b6f");
            response.EnsureSuccessStatusCode();
            string x = response.Content.ReadAsStringAsync().Result;
            return await Task.Run(() => JsonConvert.DeserializeObject<GenresList>(x));
        }
    }
}
