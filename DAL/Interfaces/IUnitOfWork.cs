using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    interface IUnitOfWork
    {
        public IRepository<Computer> ComputerRepository { get; }
        public IRepository<ComputerParts> ComputerPartsRepository { get; }
        public IRepository<Order> OrderRepository { get; }
        public IRepository<Owner> OwnerRepository { get; }
        public IRepository<Part> PartRepository { get; }
        Task Save();
    }
}
