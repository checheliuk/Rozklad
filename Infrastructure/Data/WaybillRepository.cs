using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class WaybillRepository : IWaybillRepository
{
    private readonly DataContext _context;
    public WaybillRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(Waybill waybill)
    {
        _context.Waybills.Add(waybill);
    }

    public void Delete(Waybill waybill)
    {
        _context.Waybills.Remove(waybill);
    }

    public void Update(Waybill waybill)
    {
        _context.Entry(waybill).State = EntityState.Modified;
    }
}