using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly ComputerServiceDbContext _context;
        public UnitOfWork(IRepository<Computer> computerRepository, IRepository<ComputerParts> computerPartsRepository, IRepository<Order> orderRepository, IRepository<Owner> ownerRepository, IRepository<Part> partRepository, ComputerServiceDbContext context)
        {
            ComputerRepository = computerRepository;
            ComputerPartsRepository = computerPartsRepository;
            OrderRepository = orderRepository;
            OwnerRepository = ownerRepository;
            PartRepository = partRepository;
            _context = context;
        }

        public IRepository<Computer> ComputerRepository { get; }
        public IRepository<ComputerParts> ComputerPartsRepository { get; }
        public IRepository<Order> OrderRepository { get; }
        public IRepository<Owner> OwnerRepository { get; }
        public IRepository<Part> PartRepository { get; }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
