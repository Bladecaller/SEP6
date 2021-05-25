using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


public class ActorService : IActors
{
    private string apiKey = "72d7decec4b08474aef457cd18c51628";
    private readonly HttpClient httpClient;
    public async Task<ActorItem> GetActorItem()
    {
        return await httpClient.GetJsonAsync<ActorItem>("https://api.themoviedb.org/3/person/1?api_key=" + apiKey);
    }

    public async Task<Groot> SearchForActors(string query)
    {
        return await httpClient.GetJsonAsync<Groot>("https://api.themoviedb.org/3/search/person?api_key=" + apiKey + "&query=" + query);
    }

    //public string GetActorImage(ActorItem item)
    //{
    //    return "https://image.tmdb.org/t/p/w500" + item.file_path;
    //}
    public ActorService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
}
