using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IOwnerService
    {
        IEnumerable<OwnerDTO> Find(string name);
        IEnumerable<OwnerDTO> FindByPartName(string name);
        OwnerDTO Find(int OrderId);
        IEnumerable<OwnerDTO> Find(DateTime date);
        IEnumerable<OwnerDTO> FindByComputerModel(string name);
        IEnumerable<OwnerDTO> GetAll();
    }
}