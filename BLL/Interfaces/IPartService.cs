using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IPartService
    {
        PartDTO Find(string name);
        PartDTO Find(DateTime date);
        Task<IEnumerable<PartDTO>> Find(int orderId);
    }

    
}
