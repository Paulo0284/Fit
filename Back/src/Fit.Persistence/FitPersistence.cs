using Fit.Persistence.Contextos;
using Fit.Persistence.Contratos;


namespace Fit.Persistence;

public class FitPersistence : IFitPersistence
{
    public FitContext _context { get; }
    public FitPersistence(FitContext context)
    {
        this._context = context;
        
    }
    public void Add<T>(T entity) where T : class
    {
        _context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
       _context.Remove(entity);
    }

    public void DeleteRange<T>(T[] entity) where T : class
    {
        _context.RemoveRange(entity);
    }

   public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) > 0;
    }

    public void Update<T>(T entity) where T : class
    {
       _context.Update(entity);
    }

    
}