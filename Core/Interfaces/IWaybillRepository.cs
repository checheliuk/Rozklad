using Core.Entities;

namespace Core.Interfaces;
public interface IWaybillRepository
{
    void Add(Waybill waybill);
    void Update(Waybill waybill);
    void Delete(Waybill waybill);
}