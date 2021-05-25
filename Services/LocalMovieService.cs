using System.Linq;
using System.Collections.Generic;

public class LocalMovieService{
    protected readonly ApplicationDbContext dbContext;
    public LocalMovieService(ApplicationDbContext db){
        dbContext = db;
    }

    public List<LocalMovie> displayMovieData(){
        return dbContext.movies.ToList();
    }
}