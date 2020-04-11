using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Interfaces
{
    interface IPartService
    {
        Task<Part> Find(string name);
        Task<Part> Find(DateTime date);
        Task<Part> Find(int orderId);
    }

    interface ICustomerService
    {

    }

    interface IOrderService
    {

    }
}
