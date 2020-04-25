using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(ICollection<PartDTO> partsForReplacement, decimal price);
    }
}